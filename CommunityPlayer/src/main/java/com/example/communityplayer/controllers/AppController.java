package com.example.communityplayer.controllers;

import com.example.communityplayer.*;
import com.example.communityplayer.ds.iterator.Iterator;
import com.example.communityplayer.Server;
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
import java.util.ResourceBundle;
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

        // Create Server
        createServer();

        communityPlaylist.setOnAction(event -> startServer());
        next.setOnAction(event -> nextSong(iterator));

    }

    private void nextSong(Iterator<Song> iterator) {
        Song currentSong = iterator.next().data;
        System.out.println(currentSong.getId());

        songInfoController.updateView(currentSong);
    }

    private void loadConfigFile() {
        String configFilePath = "C:/Users/andre/OneDrive/Documents/GitHub/CommunityPlayer/CommunityPlayer/src/main/resources/com/example/communityplayer/config.ini";

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

    private void createServer() {
        try {
            server = new Server(new ServerSocket(serverPort), songList);

        } catch (Exception e) {
            System.out.println("Error creando servidor!");
            e.printStackTrace();
        }

    }

    private void startServer() {
        server.start();
        server.receiveRequest(songInfoController);
    }

}