package com.example.communityplayer;

import javafx.scene.control.Button;
import javafx.scene.image.Image;
import javafx.scene.image.ImageView;

/**
 * A custom button for voting actions.
 */
public class VoteButton {
    Button button = new Button();
    boolean selected = false;

    ImageView mainImageView;

    ImageView secondaryImageView;

    /**
     * Constructs a VoteButton with the given image paths.
     *
     * @param imagePath          The path to the main image displayed on the button.
     * @param secondaryImagePath The path to the secondary image displayed on the button when selected.
     */
    public VoteButton(String imagePath, String secondaryImagePath) {
        this.mainImageView = new ImageView(new Image(imagePath));
        mainImageView.setFitWidth(24);
        mainImageView.setFitHeight(24);

        this.secondaryImageView = new ImageView(new Image(secondaryImagePath));
        secondaryImageView.setFitWidth(24);
        secondaryImageView.setFitHeight(24);

        button.setGraphic(mainImageView);
        button.setStyle("-fx-background-color: transparent;");

    }

    /**
     * Gets the button associated with this VoteButton.
     *
     * @return The button.
     */
    public Button getButton() {
        return button;
    }

    /**
     * Gets the selection state of the VoteButton.
     *
     * @return True if the button is selected, false otherwise.
     */
    public boolean getSelected() {
        return selected;
    }

    /**
     * Changes the image displayed on the button based on the current selection state.
     */
    public void changeImage() {
        if (selected) {
            button.setGraphic(mainImageView);
        } else {
            button.setGraphic(secondaryImageView);
        }
        selected = !selected;
    }
}
