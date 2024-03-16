package com.example.communityplayer.ui.components;

import com.example.communityplayer.Song;
import javafx.scene.control.Label;
import javafx.scene.layout.HBox;
import javafx.scene.text.Font;
import javafx.scene.text.Text;

/**
 * Represents a box containing voting information for a song, including up votes and down votes.
 */
public class VotesBox {

    private final Song song;
    private final HBox votesBox; // Container for the voting buttons and labels

    private enum VoteType {
        UP,
        DOWN
    }

    /**
     * Constructs a new VotesBox with the specified number of up votes, down votes, and font.
     *
     * @param song The song associated with the VotesBox.
     * @param font The font used for the vote labels.
     */
    public VotesBox(Song song, Font font) {
        this.song = song;

        votesBox = createVotesBox(font);

    }

    /**
     * Gets the HBox containing the voting buttons and labels.
     *
     * @return The HBox containing the voting buttons and labels.
     */
    public HBox getVotesBox() {
        return votesBox;
    }

    /**
     * Creates the HBox container for the voting buttons and labels.
     *
     * @param font The font used for the labels.
     * @return The HBox container for the voting buttons and labels.
     */
    private HBox createVotesBox(Font font) {
        double widthForFourChars = getWidthForFourChars(font);

        //  Up Votes
        VoteButton voteUpButton = new VoteButton("images/like.png", "images/voted-up.png");
        Label voteUpLabel = createLabel(formatLargeNumber(song.getTotalUpVotes()), font, widthForFourChars);
        HBox voteUpBox = new HBox(voteUpButton.getButton(), voteUpLabel);

        //  Down Votes
        VoteButton voteDownButton = new VoteButton("images/dislike.png", "images/voted-down.png");
        Label voteDownLabel = createLabel(formatLargeNumber(song.getTotalDownVotes()), font, widthForFourChars);
        HBox voteDownBox = new HBox(voteDownButton.getButton(), voteDownLabel);

        //  Votes Box
        HBox box = new HBox(10);
        box.getChildren().addAll(voteUpBox, voteDownBox);

        //  Votes Button functionality
        voteUpButton.getButton().setOnAction(event -> handleVote(voteUpButton, voteDownButton, voteUpLabel, voteDownLabel, VoteType.UP));
        voteDownButton.getButton().setOnAction(event -> handleVote(voteDownButton, voteUpButton, voteDownLabel, voteUpLabel, VoteType.DOWN));

        return box;
    }

    /**
     * Creates a label with the specified text, font, and maximum width.
     *
     * @param text     The text of the label.
     * @param font     The font of the label.
     * @param maxWidth The maximum width of the label.
     * @return The created label.
     */
    private Label createLabel(String text, Font font, double maxWidth) {
        Label label = new Label(text);
        label.setStyle("-fx-text-fill: white;");
        label.setFont(font);
        label.setMaxWidth(maxWidth);
        return label;
    }

    /**
     * Handles the voting action when a vote button is clicked.
     *
     * @param selectedButton The selected vote button.
     * @param otherButton    The other vote button.
     * @param selectedLabel  The label corresponding to the selected vote.
     * @param otherLabel     The label corresponding to the other vote.
     * @param voteType       Indicates if it's an up vote or down vote.
     */
    private void handleVote(VoteButton selectedButton, VoteButton otherButton, Label selectedLabel, Label otherLabel, VoteType voteType) {
        if (otherButton.getSelected()) {
            otherButton.changeImage();
            if (voteType == VoteType.UP) song.setTotalDownVotes(song.getTotalDownVotes() - 1);
            else song.setTotalUpVotes(song.getTotalUpVotes() - 1);
            otherLabel.setText(formatLargeNumber(voteType == VoteType.UP ? song.getTotalDownVotes() : song.getTotalUpVotes()));
        }
        if (!selectedButton.getSelected()) {
            if (voteType == VoteType.UP) song.setTotalUpVotes(song.getTotalUpVotes() + 1);
            else song.setTotalDownVotes(song.getTotalDownVotes() + 1);
        } else {
            if (voteType == VoteType.UP) song.setTotalUpVotes(song.getTotalUpVotes() - 1);
            else song.setTotalDownVotes(song.getTotalDownVotes() - 1);
        }
        selectedLabel.setText(formatLargeNumber(voteType == VoteType.UP ? song.getTotalUpVotes() : song.getTotalDownVotes()));
        selectedButton.changeImage();
    }

    /**
     * Formats a large number with appropriate suffixes (k, M, B).
     *
     * @param number The number to format.
     * @return The formatted number.
     */
    private String formatLargeNumber(int number) {
        if (number < 1000) {
            return String.valueOf(number);
        } else if (number < 1000000) {
            if (number < 10000 && number % 1000 == 0) {
                return (number / 1000) + "k";
            } else {
                return String.format("%.1f", number / 1000.0).replace(".0", "") + "k";
            }
        } else if (number < 1000000000) {
            if (number % 1000000 == 0) {
                return (number / 1000000) + "M";
            } else {
                return String.format("%.1f", number / 1000000.0).replace(".0", "") + "M";
            }
        } else {
            if (number % 1000000000 == 0) {
                return (number / 1000000000) + "B";
            } else {
                return String.format("%.1f", number / 1000000000.0).replace(".0", "") + "B";
            }
        }
    }

    /**
     * Calculates the width required to display four characters using the specified font.
     *
     * @param font The font used to calculate the width.
     * @return The width required for four characters.
     */
    private double getWidthForFourChars(Font font) {
        Text text = new Text("0000"); // Four characters
        text.setFont(font);
        return text.getBoundsInLocal().getWidth();
    }
}
