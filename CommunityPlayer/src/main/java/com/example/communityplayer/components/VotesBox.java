package com.example.communityplayer.components;

import javafx.scene.control.Label;
import javafx.scene.layout.HBox;
import javafx.scene.text.Font;
import javafx.scene.text.Text;

/**
 * Represents a box containing voting information for a song, including up votes and down votes.
 */
public class VotesBox {
    private int upVotes; // Number of up votes
    private int downVotes; // Number of down votes
    private final HBox votesBox; // Container for the voting buttons and labels

    /**
     * Constructs a new VotesBox with the specified number of up votes, down votes, and font.
     *
     * @param upVotes   The number of up votes.
     * @param downVotes The number of down votes.
     * @param font      The font used for the vote labels.
     */
    public VotesBox(int upVotes, int downVotes, Font font) {
        this.upVotes = upVotes;
        this.downVotes = downVotes;

        votesBox = createVotesBox(font);

    }

    /**
     * Gets the number of up votes.
     *
     * @return The number of up votes.
     */
    public int getUpVotes() {
        return upVotes;
    }

    /**
     * Gets the number of down votes.
     *
     * @return The number of down votes.
     */
    public int getDownVotes() {
        return downVotes;
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
        Label voteUpLabel = createLabel(formatLargeNumber(upVotes), font, widthForFourChars);
        HBox voteUpBox = new HBox(voteUpButton.getButton(), voteUpLabel);

        //  Down Votes
        VoteButton voteDownButton = new VoteButton("images/dislike.png", "images/voted-down.png");
        Label voteDownLabel = createLabel(formatLargeNumber(downVotes), font, widthForFourChars);
        HBox voteDownBox = new HBox(voteDownButton.getButton(), voteDownLabel);

        //  Votes Box
        HBox box = new HBox(10);
        box.getChildren().addAll(voteUpBox, voteDownBox);

        //  Votes Button functionality
        voteUpButton.getButton().setOnAction(event -> handleVote(voteUpButton, voteDownButton, voteUpLabel, voteDownLabel, true));
        voteDownButton.getButton().setOnAction(event -> handleVote(voteDownButton, voteUpButton, voteDownLabel, voteUpLabel, false));

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
     * @param isUpVote       Indicates if it's an up vote (true) or down vote (false).
     */
    private void handleVote(VoteButton selectedButton, VoteButton otherButton, Label selectedLabel, Label otherLabel, boolean isUpVote) {
        if (otherButton.getSelected()) {
            otherButton.changeImage();
            if (isUpVote) downVotes -= 1;
            else upVotes -= 1;
            otherLabel.setText(formatLargeNumber(isUpVote ? downVotes : upVotes));
        }
        if (!selectedButton.getSelected()) {
            if (isUpVote) upVotes += 1;
            else downVotes += 1;
        } else {
            if (isUpVote) upVotes -= 1;
            else downVotes -= 1;
        }
        selectedLabel.setText(formatLargeNumber(isUpVote ? upVotes : downVotes));
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
