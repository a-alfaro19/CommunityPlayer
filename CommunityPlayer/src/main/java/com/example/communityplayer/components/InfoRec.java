package com.example.communityplayer.components;

import javafx.scene.control.Label;
import javafx.scene.layout.StackPane;
import javafx.scene.layout.VBox;
import javafx.scene.shape.Rectangle;
import javafx.scene.text.Font;

/**
 * A custom information rectangle for displaying album names, genres, etc.
 */
public class InfoRec {
    private final StackPane infoRec;

    /**
     * Constructs an InfoRec object with the specified dimensions, tag, and value.
     *
     * @param width  The width of the rectangle.
     * @param height The height of the rectangle.
     * @param tag    The tag or label for the information.
     * @param value  The value or text to be displayed.
     */
    public InfoRec(double width, double height, String tag, String value) {
        Rectangle rectangle = new Rectangle(width, height);
        rectangle.getStyleClass().add("rectangle");

        VBox albumNameBox = new VBox(15);
        Label albumNameTagLabel = new Label(tag);
        albumNameTagLabel.getStyleClass().add("albumNameTagLabel");
        albumNameTagLabel.setFont(Font.loadFont(getClass().getResourceAsStream("/com/example/communityplayer/Gotham-Font/GothamMedium.ttf"), 24));

        Label albumNameLabel = new Label(value);
        albumNameLabel.getStyleClass().add("albumNameLabel");
        albumNameLabel.setFont(Font.loadFont(getClass().getResourceAsStream("/com/example/communityplayer/Gotham-Font/GothamMedium.ttf"), 16));

        albumNameBox.getChildren().addAll(albumNameTagLabel, albumNameLabel);
        albumNameBox.getStyleClass().add("albumNameBox");

        infoRec = new StackPane();
        infoRec.getChildren().addAll(rectangle, albumNameBox);
    }

    /**
     * Gets the StackPane containing the information rectangle.
     *
     * @return The StackPane.
     */
    public StackPane getInfoRec() {
        return infoRec;
    }
}
