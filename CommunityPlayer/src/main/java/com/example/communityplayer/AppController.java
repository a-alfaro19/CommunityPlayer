package com.example.communityplayer;

import com.example.communityplayer.ds.DoubleLinkedList;
import com.example.communityplayer.ds.iterator.Iterator;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.layout.HBox;
import org.ini4j.Ini;
import org.ini4j.IniPreferences;

import java.io.File;
import java.io.IOException;
import java.util.prefs.Preferences;

public class AppController {
    public HBox root;
    private DoubleLinkedList<Song> songList;
    private int serverPort;
    private String songLibraryPath;



    public void initialize() {
        // Load Config File
        String configFilePath = "C:/Users/andre/OneDrive/Documents/GitHub/CommunityPlayer/CommunityPlayer/src/main/resources/com/example/communityplayer/config.ini";
        try {
            loadConfigFile(configFilePath);
        } catch (IOException e) {
            e.printStackTrace();
        }

        // Create song list
        MP3MetadataExtractor extractor = new MP3MetadataExtractor(songLibraryPath);
        songList = extractor.getSongList();

        // Song Section Controller
        Iterator<Song> iterator = songList.createIterator();
        loadSongInfoSection(iterator.next().data);

    }

    private void loadConfigFile(String filePath) throws IOException {
        Ini iniConfig = new Ini(new File(filePath)); // Load the INI file
        Preferences prefs = new IniPreferences(iniConfig); // Create preferences from the INI file

        // Retrieve values from the INI file
        serverPort = prefs.node("Server").getInt("PORT", -1); // Default value is -1 if not found
        songLibraryPath = prefs.node("Server").get("LIBRARY_PATH", ""); // Default value is an empty string if not found
    }

    private void loadSongInfoSection(Song currentSong) {
        FXMLLoader loader = new FXMLLoader(getClass().getResource("view/SongInfoSection.fxml"));

        try {
            Parent songInfoSectionRoot = loader.load();
            SongInfoSectionController songInfoSectionController = loader.getController();

            songInfoSectionController.initialize(currentSong);

            root.getChildren().add(songInfoSectionRoot);
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

}