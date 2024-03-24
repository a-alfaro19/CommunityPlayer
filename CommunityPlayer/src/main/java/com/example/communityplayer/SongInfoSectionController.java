package com.example.communityplayer;

import javafx.fxml.FXML;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.image.Image;
import javafx.scene.image.ImageView;
import javafx.scene.shape.Rectangle;
import javafx.scene.paint.Color;
import javafx.scene.SnapshotParameters;
import javafx.scene.image.WritableImage;
import org.jaudiotagger.tag.datatype.Artwork;

import java.awt.*;
import java.io.ByteArrayInputStream;
import java.io.File;
import java.io.IOException;
import java.util.Objects;

public class SongInfoSectionController {
    public Label songName;
    public Label artistName;
    public Label totalUpVotes;
    public ImageView upVotesIcon;
    public ImageView downVotesIcon;
    public Label totalDownVotes;
    public Label songAlbum;
    public Label songGenre;
    public Button referenceButton;
    @FXML
    private ImageView songImageView;

    private Song currentSong;

    public void initialize(Song currentSong) {
        this.currentSong = currentSong;

        songName.setText(currentSong.getSongName());
        artistName.setText(currentSong.getArtistName());
        upVotesIcon.setImage(new Image(Objects.requireNonNull(getClass().getResource("images/like.png")).toExternalForm()));
        totalUpVotes.setText(String.valueOf(currentSong.getTotalUpVotes()));
        downVotesIcon.setImage(new Image(Objects.requireNonNull(getClass().getResource("images/dislike.png")).toExternalForm()));
        totalDownVotes.setText(String.valueOf(currentSong.getTotalDownVotes()));
        songAlbum.setText(currentSong.getAlbumName());
        songGenre.setText(currentSong.getMusicGenre());

        referenceButton.setOnAction(event -> openFileExplorer(currentSong.getFilePath()));

        loadArtWork();
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
        songImageView.setFitWidth(297);
        songImageView.setFitHeight(297);

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
