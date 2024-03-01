package com.example.communityplayer;

import javafx.geometry.Insets;
import javafx.scene.control.Label;
import javafx.scene.image.ImageView;
import javafx.scene.layout.HBox;
import javafx.scene.layout.StackPane;
import javafx.scene.layout.VBox;
import javafx.scene.text.Font;

/**
 * Class representing the section for displaying song information.
 */
public class SongInfoSection {
    private final VBox pane;

    /**
     * Constructor for the SongInfoSection class.
     *
     * @param song          The song for which information is displayed.
     * @param fatherSize    The size of the parent container.
     * @param fatherPadding The padding of the parent container.
     */
    public SongInfoSection(Song song, double[] fatherSize, int fatherPadding) {
//      Pane box params
        double[] size = new double[]{fatherSize[0] * 0.25, fatherSize[1] - (2 * fatherPadding)};
        int paddingX = 20;
        int paddingY = 25;
        double paneContentWidth = size[0] - (2 * paddingX);

//      Pane
        pane = new VBox(20);
        pane.setPrefSize(size[0], size[1]);
        pane.setStyle("-fx-background-radius: 5; -fx-background-color: #121111;");
        pane.setPadding(new Insets(paddingY, paddingX, paddingY, paddingX));

//      Title
        Label title = createLabel("Ahora reproduciendo", 18, "white");

//      Song Image
        ImageView songImageView = new SongImage(paneContentWidth, song.getImagePath()).getImage();

//      Song Name
        Label songName = createLabel(song.getSongName(), 32, "white");

//      Artist Name
        Label songArtist = createLabel(song.getArtistName(), 18, "#C0C0C0");

//      Up Votes
        VoteButton voteUpButton = new VoteButton("like.png", "voted-up.png");
        Label voteUpLabel = createLabel(String.valueOf(song.getTotalUpVotes()), 30, "white");
        HBox voteUpBox = new HBox(voteUpButton.getButton(), voteUpLabel);

//      Down Votes
        VoteButton voteDownButton = new VoteButton("dislike.png", "voted-down.png");
        Label voteDownLabel = createLabel(String.valueOf(song.getTotalDownVotes()), 30, "white");
        HBox voteDownBox = new HBox(voteDownButton.getButton(), voteDownLabel);

//      Votes Box
        HBox votesBox = new HBox(10);
        votesBox.getChildren().addAll(voteUpBox, voteDownBox);

//      Votes Button functionality
        voteUpButton.getButton().setOnAction(event -> handleUpVote(voteUpButton, voteDownButton, voteUpLabel, voteDownLabel, song));

        voteDownButton.getButton().setOnAction(event -> handleDownVote(voteDownButton, voteUpButton, voteDownLabel, voteUpLabel, song));

//      Album Name
        StackPane albumPane = new InfoRec(paneContentWidth, 70, "Album", song.getAlbumName()).getInfoRec();

//      Genre
        StackPane genrePane = new InfoRec(paneContentWidth, 70, "Género", song.getMusicGenre()).getInfoRec();

//      Song Info Box
        VBox songInfoBox = new VBox(10);
        songInfoBox.getChildren().addAll(songName, songArtist, votesBox, albumPane, genrePane);

//      Add elements to the main pane
        pane.getChildren().addAll(title, songImageView, songInfoBox);

    }

    /**
     * Method to get the pane containing the song information section.
     *
     * @return The VBox containing the song information.
     */
    public VBox getPane() {
        return pane;
    }

    // Private method to create a label with the specified text, font size, and text color
    private Label createLabel(String text, double fontSize, String textColor) {
        Label label = new Label(text);
        label.setStyle("-fx-text-fill: " + textColor + ";");
        label.setFont(Font.loadFont(getClass().getResourceAsStream("Gotham-Font/Gotham-Bold.otf"), fontSize));
        return label;
    }

    // Private method to handle up vote
    private void handleUpVote(VoteButton voteUpButton, VoteButton voteDownButton, Label voteUpLabel, Label voteDownLabel, Song song) {
        if (voteDownButton.getSelected()) {
            voteDownButton.changeImage();
            song.reduceDownVote();
            voteDownLabel.setText(String.valueOf(song.getTotalDownVotes()));
        }
        if (!voteUpButton.getSelected()) {
            song.addUpVote();
        } else {
            song.reduceUpVote();
        }
        voteUpLabel.setText(String.valueOf(song.getTotalUpVotes()));
        voteUpButton.changeImage();
    }

    // Private method to handle down vote
    private void handleDownVote(VoteButton voteDownButton, VoteButton voteUpButton, Label voteDownLabel, Label voteUpLabel, Song song) {
        if (voteUpButton.getSelected()) {
            voteUpButton.changeImage();
            song.reduceUpVote();
            voteUpLabel.setText(String.valueOf(song.getTotalUpVotes()));
        }
        if (!voteDownButton.getSelected()) {
            song.addDownVote();
        } else {
            song.reduceDownVote();
        }
        voteDownLabel.setText(String.valueOf(song.getTotalDownVotes()));
        voteDownButton.changeImage();
    }

}

// TODO: Agregar referencia al archivo mp3.