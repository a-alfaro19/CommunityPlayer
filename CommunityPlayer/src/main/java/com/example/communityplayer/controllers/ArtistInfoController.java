package com.example.communityplayer.controllers;

import com.example.communityplayer.Song;
import com.example.communityplayer.SongPlaylist;
import com.example.communityplayer.ds.CustomList;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.*;
import javafx.scene.input.MouseButton;

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

    private BarController barController;
    private SongInfoController songInfoController;

    // Método para establecer la instancia de SongPlaylist
    public void setSongList(SongPlaylist songList) {
        this.songList = songList;
    }

    public void setBarController(BarController barController) {
        this.barController = barController;
    }

    public void setSongInfoController(SongInfoController songInfoController) {
        this.songInfoController = songInfoController;
    }

    @Override
    public void initialize(URL location, ResourceBundle resources) {
        // Agregar evento de doble clic a todas las listas de canciones
        setDoubleClickEvent(artistSongList);
        setDoubleClickEvent(artistSongList1);
        setDoubleClickEvent(artistSongList2);
        setDoubleClickEvent(artistSongList3);
        setDoubleClickEvent(artistSongList31);
        setDoubleClickEvent(artistSongList32);
        setDoubleClickEvent(artistSongList33);

        // Asignar acciones a los botones
        badBunnyButton.setOnAction(event -> loadArtistSongs("Bad Bunny", artistSongList));
        edSheeranButton.setOnAction(event -> loadArtistSongs("Ed Sheeran", artistSongList1));
        jojiButton.setOnAction(event -> loadArtistSongs("Joji", artistSongList31));
        travisScottButton.setOnAction(event -> loadArtistSongs("Travis Scott", artistSongList32));
        eminemButton.setOnAction(event -> loadArtistSongs("Eminem", artistSongList33));
        frankOceanButton.setOnAction(event -> loadArtistSongs("Frank Ocean", artistSongList2));
        theWeekndButton.setOnAction(event -> loadArtistSongs("The Weeknd", artistSongList3));
    }

    // Método para establecer el evento de doble clic en una ListView
    private void setDoubleClickEvent(ListView<String> listView) {
        listView.setOnMouseClicked(event -> {
            if (event.getButton().equals(MouseButton.PRIMARY) && event.getClickCount() == 2) {
                String selectedSong = listView.getSelectionModel().getSelectedItem();
                if (selectedSong != null) {
                    playSelectedSong(selectedSong);
                }
            }
        });
    }

    private void loadArtistSongs(String artistName, ListView<String> listView) {
        if (songList != null) {
            CustomList<Song> songs = songList.getSongsByArtist(artistName);
            System.out.println("Número de canciones para " + artistName + ": " + songs.size());
            listView.getItems().clear();
            for (int i = 0; i < songs.size(); i++) {
                Song song = songs.get(i);
                String songName = song.getSongName();
                System.out.println("Nombre de la canción: " + songName);
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

    private void playSelectedSong(String songName) {
        if (songList != null && barController != null) {
            Song selectedSong = songList.getSongByName(songName);
            if (selectedSong != null) {
                barController.updateView(selectedSong);
                songInfoController.updateView(selectedSong);
            } else {
                new Alert(Alert.AlertType.ERROR, "No se encontró la canción seleccionada.", ButtonType.OK).showAndWait();
            }
        } else {
            new Alert(Alert.AlertType.ERROR, "No se pueden reproducir canciones.", ButtonType.OK).showAndWait();
        }
    }
}
