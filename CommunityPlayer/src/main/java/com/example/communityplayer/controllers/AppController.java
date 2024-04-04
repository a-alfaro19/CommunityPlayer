package com.example.communityplayer.controllers;

import com.example.communityplayer.*;
import com.example.communityplayer.ds.iterator.Iterator;
import com.example.communityplayer.Server;
import com.example.communityplayer.json.JsonRequest;
import com.example.communityplayer.json.JsonRequestTypeAdapter;
import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import javafx.application.Platform;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import javafx.scene.Parent;
import javafx.scene.control.Button;
import javafx.scene.layout.AnchorPane;
import javafx.scene.layout.HBox;
import org.ini4j.Ini;
import org.ini4j.IniPreferences;

import java.io.File;
import java.io.IOException;
import java.net.ServerSocket;
import java.net.URL;
import java.util.Arrays;
import java.util.Random;
import java.util.ResourceBundle;
import java.util.UUID;
import java.util.prefs.Preferences;

public class AppController implements Initializable {
    public AnchorPane main;
    @FXML
    public HBox sectionBox;
    @FXML
    private SongInfoController songInfoController;
    @FXML
    public Button communityPlaylist;
    @FXML
    public Button next;

    private SongPlaylist songList;
    private Iterator<Song> iterator; // temp
    private SongPlaylist playlist;
    private int serverPort;
    private Server server;
    private String songLibraryPath;


    @Override
    public void initialize(URL location, ResourceBundle resources) {
        // Sections
        loadSongInfoSection();

        // Load Config File
        loadConfigFile();

        // Create song list
        loadSongLibrary();
        iterator = songList.createIterator();

        communityPlaylist.setOnAction(event -> startServer());
        next.setOnAction(event -> nextSong(iterator));

    }

    private void nextSong(Iterator<Song> iterator) {
        Song currentSong = iterator.next().data;
        System.out.println(currentSong.getId());

        songInfoController.updateView(currentSong);
    }

    private void loadConfigFile() {
        String configFilePath = "src/main/java/com/example/communityplayer/config.ini";

        try {
            Ini iniConfig = new Ini(new File(configFilePath)); // Load the INI file
            Preferences prefs = new IniPreferences(iniConfig); // Create preferences from the INI file

            // Retrieve values from the INI file
            serverPort = prefs.node("Server").getInt("PORT", -1); // Default value is -1 if not found
            songLibraryPath = prefs.node("Server").get("LIBRARY_PATH", ""); // Default value is an empty string if not found

        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    private void loadSongLibrary() {
        MP3MetadataExtractor extractor = new MP3MetadataExtractor(songLibraryPath);
        songList = extractor.getSongList();
    }

    private void loadSongInfoSection() {

        try {
            FXMLLoader loader = new FXMLLoader(getClass().getResource("songInfoSection.fxml"));
            Parent songInfoSection = loader.load();
            songInfoController = loader.getController();

            sectionBox.getChildren().add(songInfoSection);

        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    private void createPlaylist() {
        playlist = new SongPlaylist();
        Iterator<Song> iterator = songList.createIterator();

        while (playlist.getSize() != 10) {
            playlist.insert(iterator.next().data);
        }

    }

    private void startServer() {
        createPlaylist();

        try {
            server = new Server(new ServerSocket(serverPort));

            while (true) {
                server.listen();
                String request = server.receiveRequest();
                String response = processRequest(request);
                server.sendResponse(response);
                server.close();
            }

        } catch (Exception e) {
            e.printStackTrace();
        }


    }

    private String processRequest(String request) {
        JsonRequest jsonRequest = parseJSON(request);

        String command = jsonRequest.command;
        System.out.println(command);
        String songId = jsonRequest.songId;

        Song song;
        if (songId != null) {
            song = playlist.getById(UUID.fromString(songId));

        } else {
            song = null;
        }

        String response = "";
        switch (command) {
            case "Get-Playlist":
                System.out.println("Getting Playlist");
                response = playlist.toString();
                break;

            case "Vote-up":
                if (songId != null) {
                    song.voteUp();
                    Platform.runLater(() -> {
                        songInfoController.totalUpVotes.setText(String.valueOf(song.getTotalUpVotes()));
                    });

                    System.out.println("Voted Up: " + song.getTotalUpVotes());
                    response = "OK";
                }
                break;

            case "Vote-down":
                if (songId != null) {
                    song.voteDown();
                    Platform.runLater(() -> {
                        songInfoController.totalDownVotes.setText(String.valueOf(song.getTotalDownVotes()));
                    });
                    System.out.println("Voted Down: " + song.getTotalDownVotes());
                    response = "OK";
                }
                break;

            default:
                System.out.println("Comando desconocido: " + command);
                response = "ERROR";
                break;

        }

        return response;

    }

    private JsonRequest parseJSON(String json) {
        Gson gson = new GsonBuilder().registerTypeAdapter(JsonRequest.class, new JsonRequestTypeAdapter()).create();
        return gson.fromJson(json, JsonRequest.class);
    }

}