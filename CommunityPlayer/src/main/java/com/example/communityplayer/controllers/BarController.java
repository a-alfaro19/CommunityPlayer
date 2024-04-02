package com.example.communityplayer.controllers;

import com.example.communityplayer.Song;
import javafx.beans.value.ChangeListener;
import javafx.beans.value.ObservableValue;
import javafx.fxml.FXML;
import javafx.scene.SnapshotParameters;
import javafx.scene.control.Label;
import javafx.scene.control.ProgressBar;
import javafx.scene.image.Image;
import javafx.scene.image.ImageView;
import javafx.scene.image.WritableImage;
import javafx.scene.paint.Color;
import javafx.util.Duration;
import org.jaudiotagger.tag.datatype.Artwork;
import javafx.scene.control.Button;
import java.io.ByteArrayInputStream;
import java.io.File;
import java.net.URL;
import java.util.Objects;
import java.util.ResourceBundle;
import javafx.fxml.Initializable;
import javafx.scene.media.Media;
import javafx.scene.media.MediaPlayer;

public class BarController implements Initializable{
    @FXML
    private ImageView songImageView;
    @FXML
    public Label songName;
    @FXML
    public Label artistName;
    @FXML
    public Button playButtomIcon;
    @FXML
    public Button nextButtomIcon;
    @FXML
    public Button previousButtomIcon;
    @FXML
    public Button deleteButtomIcon;
    @FXML
    public ImageView volumenIcon;
    @FXML
    public ProgressBar progressBarSong;
    @FXML
    public ProgressBar progressBarVol;
    @FXML
    private Label currentTimeLabel;
    @FXML
    private Label currentFinalTimeLabel;
    public MediaPlayer mediaPlayer;
    private Duration currentTime;
    private Song currentSong;
    private double currentVolume = 1;


    @Override
    public void initialize(URL url, ResourceBundle resourceBundle) {
        ImageView playImageView = new ImageView(new Image(Objects.requireNonNull(getClass().getResourceAsStream("images/PlayB.png"))));
        playImageView.setFitWidth(35);
        playImageView.setFitHeight(35);
        playButtomIcon.setGraphic(playImageView);
        playButtomIcon.setOnAction(event -> togglePlayPause());

        ImageView nextImageView = new ImageView(new Image(Objects.requireNonNull(getClass().getResourceAsStream("images/next.png"))));
        nextImageView.setFitHeight(18);
        nextImageView.setFitWidth(18);
        nextButtomIcon.setGraphic(nextImageView);

        ImageView previousImageView = new ImageView(new Image(Objects.requireNonNull(getClass().getResourceAsStream("images/previus.png"))));
        previousImageView.setFitWidth(18);
        previousImageView.setFitHeight(18);
        previousButtomIcon.setGraphic(previousImageView);

        ImageView deleteImageView = new ImageView(new Image(Objects.requireNonNull(getClass().getResourceAsStream("images/delete.png"))));
        deleteImageView.setFitHeight(19);
        deleteImageView.setFitWidth(19);
        deleteButtomIcon.setGraphic(deleteImageView);

        volumenIcon.setImage(new Image(Objects.requireNonNull(getClass().getResource("images/Volumen.png")).toExternalForm()));

        ProgressBarDragHandler();
        volumeProgressBarDragHandler();

    }

    public void updateView(Song currentSong) {
        this.currentSong = currentSong;
        songImageView.setVisible(true);
        songName.setText(currentSong.getSongName());
        artistName.setText(currentSong.getArtistName());
        loadArtWork();
        pauseSong();
        currentTime = Duration.ZERO;
        playSong();
        mediaPlayer.setVolume(currentVolume);
        progressBarVol.setProgress(currentVolume);
    }

    private Artwork getSongArtWork() {
        return currentSong.getArtwork();
    }

    private void loadArtWork() {
        Artwork artwork = getSongArtWork();

        if (artwork != null) {
            byte[] imageData = artwork.getBinaryData();
            Image songImage = new Image(new ByteArrayInputStream(imageData));
            songImageView.setImage(songImage);
        } else {
            Image defaultImage = new Image(Objects.requireNonNull(getClass().getResource("images/unknown.jpg")).toExternalForm());
            songImageView.setImage(defaultImage);
        }
        songImageView.setFitWidth(76);
        songImageView.setFitHeight(76);

        SnapshotParameters parameters = new SnapshotParameters();
        parameters.setFill(Color.TRANSPARENT);
        WritableImage writableImage = songImageView.snapshot(parameters, null);

        songImageView.setClip(null);
        songImageView.setImage(writableImage);
    }

    private String getFilePathSong() {
        return currentSong.getFilePath();
    }

    private void playSong() {
        String filePath = getFilePathSong();
        Media media = new Media(new File(filePath).toURI().toString());
        mediaPlayer = new MediaPlayer(media);
        mediaPlayer.setOnReady(() -> {
            mediaPlayer.seek(currentTime);
            mediaPlayer.play();
            setPauseButtonImage("images/PlayB.png");
            addMediaPlayerChangeListener();
            TimeLabelUpdater();
            mediaPlayer.setVolume(currentVolume);
            progressBarVol.setProgress(currentVolume);
        });
        mediaPlayer.setOnEndOfMedia(() -> {
        });
    }
    private void pauseSong() {
        if (mediaPlayer != null && mediaPlayer.getStatus() == MediaPlayer.Status.PLAYING) {
            currentTime = mediaPlayer.getCurrentTime();
            mediaPlayer.pause();
            setPlayButtonImage("images/PauseB.png");
        }
    }
    private void togglePlayPause() {
        if (mediaPlayer != null) {
            if (mediaPlayer.getStatus() == MediaPlayer.Status.PLAYING) {
                pauseSong();
            } else {
                playSong();
            }
        }
    }
    private void setPlayButtonImage(String imagePath) {
        ImageView playImageView = new ImageView(new Image(Objects.requireNonNull(getClass().getResourceAsStream(imagePath))));
        playImageView.setFitWidth(35);
        playImageView.setFitHeight(35);
        playButtomIcon.setGraphic(playImageView);
    }
    private void setPauseButtonImage(String imagePath) {
        ImageView pauseImageView = new ImageView(new Image(Objects.requireNonNull(getClass().getResourceAsStream(imagePath))));
        pauseImageView.setFitWidth(35);
        pauseImageView.setFitHeight(35);
        playButtomIcon.setGraphic(pauseImageView);
    }
    private void addMediaPlayerChangeListener() {
        mediaPlayer.currentTimeProperty().addListener(new ChangeListener<Duration>() {
            @Override
            public void changed(ObservableValue<? extends Duration> observable, Duration oldValue, Duration newValue) {
                if (newValue != null) {
                    double progress = newValue.toMillis() / mediaPlayer.getTotalDuration().toMillis();
                    progressBarSong.setProgress(progress);
                }
            }
        });
    }
    private void ProgressBarDragHandler() {
        progressBarSong.setOnMouseDragged(event -> {
            double mouseX = event.getX();
            double progressBarWidth = progressBarSong.getWidth();
            double newTime = (mouseX / progressBarWidth) * mediaPlayer.getTotalDuration().toMillis();
            mediaPlayer.seek(Duration.millis(newTime));
        });
    }
    private void TimeLabelUpdater() {
        mediaPlayer.currentTimeProperty().addListener((observable, oldValue, newValue) -> {
            if (newValue != null) {
                Duration duration = mediaPlayer.getTotalDuration();
                long currentSeconds = (long) newValue.toSeconds();
                long totalSeconds = (long) duration.toSeconds();
                long currentMinutes = currentSeconds / 60;
                long remainingSeconds = currentSeconds % 60;
                long totalMinutes = totalSeconds / 60;
                long totalRemainingSeconds = totalSeconds % 60;
                String currentTime = String.format("%02d:%02d", currentMinutes, remainingSeconds);
                String currentFinalTime = String.format(" %02d:%02d",totalMinutes,totalRemainingSeconds);
                currentFinalTimeLabel.setText(currentFinalTime);
                currentTimeLabel.setText(currentTime);
            }
        });
    }
    private void volumeProgressBarDragHandler() {
        progressBarVol.setOnMouseDragged(event -> {
            double mouseX = event.getX();
            double progressBarWidth = progressBarVol.getWidth();
            double newVolume = (mouseX / progressBarWidth);
            mediaPlayer.setVolume(newVolume);
            progressBarVol.setProgress(newVolume);
            currentVolume = newVolume;
        });
    }
}