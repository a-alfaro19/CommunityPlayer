package com.example.communityplayer.controllers;

import com.example.communityplayer.Song;
import javafx.beans.value.ChangeListener;
import javafx.beans.value.ObservableValue;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.image.Image;
import javafx.scene.image.ImageView;
import javafx.scene.layout.VBox;
import javafx.scene.shape.Rectangle;
import javafx.scene.paint.Color;
import javafx.scene.SnapshotParameters;
import javafx.scene.image.WritableImage;
import org.jaudiotagger.tag.datatype.Artwork;

import java.awt.*;
import java.io.ByteArrayInputStream;
import java.io.File;
import java.io.IOException;
import java.net.URL;
import java.util.Objects;
import java.util.ResourceBundle;

public class SongInfoController implements Initializable {

    @FXML
    private ImageView songImageView;
    @FXML
    public VBox songDataBox;
    @FXML
    public Label songName;
    @FXML
    public Label artistName;
    @FXML
    public Label totalUpVotes;
    @FXML
    public ImageView upVotesIcon;
    @FXML
    public ImageView downVotesIcon;
    @FXML
    public Label totalDownVotes;
    @FXML
    public Label songAlbum;
    @FXML
    public Label songGenre;
    @FXML
    public Button referenceButton;

    private Song currentSong;

    @Override
    public void initialize(URL url, ResourceBundle resourceBundle) {
        totalUpVotes.textProperty().addListener(new ChangeListener<String>() {
            @Override
            public void changed(ObservableValue<? extends String> observableValue, String s, String t1) {

            }
        });


    }

    public void updateView(Song currentSong) {
        this.currentSong = currentSong;

        songImageView.setVisible(true);
        songDataBox.setVisible(true);

        loadArtWork();
        songName.setText(currentSong.getSongName());
        artistName.setText(currentSong.getArtistName());
        upVotesIcon.setImage(new Image(Objects.requireNonNull(getClass().getResource("images/like.png")).toExternalForm()));
        totalUpVotes.setText(String.valueOf(currentSong.getTotalUpVotes()));
        downVotesIcon.setImage(new Image(Objects.requireNonNull(getClass().getResource("images/dislike.png")).toExternalForm()));
        totalDownVotes.setText(String.valueOf(currentSong.getTotalDownVotes()));
        songAlbum.setText(currentSong.getAlbumName());
        songGenre.setText(currentSong.getMusicGenre());
        referenceButton.setOnAction(event -> openFileExplorer(currentSong.getFilePath()));
    }

    private Artwork getSongArtWork() {
        return currentSong.getArtwork();
    }

    private void loadArtWork() {
        // Set Song ArtWork Image
        Artwork artwork = getSongArtWork();

        if (artwork != null) {
            byte[] imageData = artwork.getBinaryData();
            Image songImage = new Image(new ByteArrayInputStream(imageData));
            songImageView.setImage(songImage);
        } else {
            Image defaultImage = new Image(Objects.requireNonNull(getClass().getResource("images/unknown.jpg")).toExternalForm());
            songImageView.setImage(defaultImage);
        }
        songImageView.setFitWidth(200);
        songImageView.setFitHeight(200);

        Rectangle clipRect = new Rectangle(
                songImageView.getFitWidth(), songImageView.getFitHeight()
        );
        clipRect.setArcWidth(20);
        clipRect.setArcHeight(20);
        songImageView.setClip(clipRect);

        // Create a snapshot of the clipped image to remove the white border around the rounded corners
        SnapshotParameters parameters = new SnapshotParameters();
        parameters.setFill(Color.TRANSPARENT);
        WritableImage writableImage = songImageView.snapshot(parameters, null);

        // Remove the clip and set the snapshot as the image
        songImageView.setClip(null);
        songImageView.setImage(writableImage);
    }

    /**
     * Opens the file explorer at the specified file path.
     *
     * @param filePath The path of the file or directory to be opened in the file explorer.
     */
    private void openFileExplorer(String filePath) {
        try {
            File directory = new File(filePath);
            Desktop.getDesktop().open(directory);
            System.out.println("Se abrió el explorador de archivos en el directorio: " + filePath);

        } catch (IOException e) {
            System.out.println("No se pudo abrir el explorador de archivos.");
            e.printStackTrace();
        }
    }

}
