package com.example.communityplayer.ui.components;

import javafx.scene.SnapshotParameters;
import javafx.scene.image.Image;
import javafx.scene.image.ImageView;
import javafx.scene.image.WritableImage;
import javafx.scene.paint.Color;
import javafx.scene.shape.Rectangle;
import org.jaudiotagger.tag.datatype.Artwork;

import java.io.ByteArrayInputStream;
import java.util.Objects;

/**
 * A custom class for displaying song images with rounded corners.
 */
public class SongImage {
    private final ImageView image;

    /**
     * Constructs a SongImage object with the specified size and mp3 artwork.
     *
     * @param size    The size of the image (width and height).
     * @param artwork The artwork from the mp3 file.
     */
    public SongImage(double size, Artwork artwork) {
        if (artwork != null) {
            byte[] imageData = artwork.getBinaryData();
            Image songImage = new Image(new ByteArrayInputStream(imageData));
            image = new ImageView(songImage);
        } else {
            Image songImage = new Image(Objects.requireNonNull(getClass().getResource("images/unknown.jpg")).toExternalForm());
            image = new ImageView(songImage);
        }
        image.setFitWidth(size);
        image.setFitHeight(size);

        // Create a rectangle to clip the image and give it rounded corners
        Rectangle clip = new Rectangle(
                image.getFitWidth(), image.getFitHeight()
        );
        clip.setArcWidth(20);
        clip.setArcHeight(20);
        image.setClip(clip);

        // Create a snapshot of the clipped image to remove the white border around the rounded corners
        SnapshotParameters parameters = new SnapshotParameters();
        parameters.setFill(Color.TRANSPARENT);
        WritableImage writableImage = image.snapshot(parameters, null);

        // Remove the clip and set the snapshot as the image
        image.setClip(null);
        image.setImage(writableImage);
    }

    /**
     * Gets the ImageView containing the song image.
     *
     * @return The ImageView.
     */
    public ImageView getImage() {
        return image;
    }
}
