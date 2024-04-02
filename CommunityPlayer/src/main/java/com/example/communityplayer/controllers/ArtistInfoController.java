package com.example.communityplayer.controllers;

import com.example.communityplayer.Song;
import com.example.communityplayer.SongPlaylist;
import com.example.communityplayer.ds.CustomList;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Button;
import javafx.scene.control.ListView;
import javafx.scene.control.Tab;
import javafx.scene.control.TabPane;

import java.net.URL;
import java.util.ResourceBundle;

public class ArtistInfoController implements Initializable {
    @FXML
    private TabPane tabPane;

    @FXML
    private ListView<String> artistSongList, artistSongList1, artistSongList2, artistSongList3, artistSongList31, artistSongList32, artistSongList33;

    @FXML
    private Button badBunnyButton, edSheeranButton, jojiButton, travisScottButton, eminemButton, frankOceanButton, theWeekndButton;

    private SongPlaylist songList;

    // Método para establecer la instancia de SongPlaylist
    public void setSongList(SongPlaylist songList) {
        this.songList = songList;
    }
    @Override
    public void initialize(URL location, ResourceBundle resources) {
        // Asignar acciones a los botones
        badBunnyButton.setOnAction(event -> loadArtistSongs("Bad Bunny", artistSongList));
        edSheeranButton.setOnAction(event -> loadArtistSongs("Ed Sheeran", artistSongList1));
        jojiButton.setOnAction(event -> loadArtistSongs("Joji", artistSongList31));
        travisScottButton.setOnAction(event -> loadArtistSongs("Travis Scott", artistSongList32));
        eminemButton.setOnAction(event -> loadArtistSongs("Eminem", artistSongList33));
        frankOceanButton.setOnAction(event -> loadArtistSongs("Frank Ocean", artistSongList2));
        theWeekndButton.setOnAction(event -> loadArtistSongs("The Weeknd", artistSongList3));
    }

    private void loadArtistSongs(String artistName, ListView<String> listView) {
        if (songList != null) {
            CustomList<Song> songs = songList.getSongsByArtist(artistName);
            System.out.println("Número de canciones para " + artistName + ": " + songs.size()); // Añadir esta línea para verificar el tamaño de la lista de canciones
            listView.getItems().clear();
            for (int i = 0; i < songs.size(); i++) {
                Song song = songs.get(i);
                String songName = song.getSongName();
                System.out.println("Nombre de la canción: " + songName); // Añadir esta línea para verificar el nombre de la canción
                listView.getItems().add(songName);
            }
            selectTab(artistName);
        } else {
            System.out.println("La lista de canciones es nula. No se pueden cargar las canciones del artista.");
        }
    }

    private void selectTab(String artistName) {
        for (Tab tab : tabPane.getTabs()) {
            if (tab.getText().equalsIgnoreCase(artistName)) {
                tabPane.getSelectionModel().select(tab);
                break;
            }
        }
    }
}
