package com.example.communityplayer;

import javafx.geometry.Insets;
import javafx.scene.control.Label;
import javafx.scene.layout.StackPane;
import javafx.scene.layout.VBox;
import javafx.scene.paint.Color;
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
        rectangle.setFill(Color.web("#232323"));
        rectangle.setArcWidth(20);
        rectangle.setArcHeight(20);

        VBox albumNameBox = new VBox(15);
        Label albumNameTagLabel = new Label(tag);
        albumNameTagLabel.setStyle("-fx-text-fill: white; -fx-underline: true;");
        albumNameTagLabel.setFont(Font.loadFont(getClass().getResourceAsStream("Gotham-Font/GothamMedium.ttf"), 24));
        Label albumNameLabel = new Label(value);
        albumNameLabel.setStyle("-fx-text-fill: #C0C0C0;");
        albumNameLabel.setFont(Font.loadFont(getClass().getResourceAsStream("Gotham-Font/GothamMedium.ttf"), 18));
        albumNameBox.getChildren().addAll(albumNameTagLabel, albumNameLabel);
        albumNameBox.setPadding(new Insets(15, 10, 15, 10));

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
