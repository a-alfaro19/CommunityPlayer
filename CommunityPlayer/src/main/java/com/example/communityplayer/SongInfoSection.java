package com.example.communityplayer;

import com.example.communityplayer.components.InfoRec;
import com.example.communityplayer.components.SongImage;
import com.example.communityplayer.components.VotesBox;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.image.ImageView;
import javafx.scene.layout.StackPane;
import javafx.scene.layout.VBox;
import javafx.scene.text.Font;

import java.io.File;
import java.io.IOException;

import java.awt.Desktop;

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
        // Fonts
        String primaryFontPath = "Gotham-Font/Gotham-Bold.otf";
        String buttonFontPath = "Gotham-Font/Gotham-Black.otf";

        //  Pane box params
        double[] size = new double[]{fatherSize[0] * 0.25, fatherSize[1] - (2 * fatherPadding)};
        int paddingX = 20;
        double paneContentWidth = size[0] - (2 * paddingX);

        //  Pane
        pane = new VBox(20);
        pane.setPrefSize(size[0], size[1]);
        pane.getStyleClass().add("song-info-box");

        //  Title
        Font titleFont = loadFont(primaryFontPath, 18);
        Label title = createLabel("Ahora reproduciendo", titleFont, "white");

        //  Song Image
        ImageView songImageView = new SongImage(paneContentWidth, song.getImagePath()).getImage();

        //  Song Name
        Font songNameFont = loadFont(primaryFontPath, 32);
        Label songName = createLabel(song.getSongName(), songNameFont, "white");

        //  Artist Name
        Font sonArtistFont = loadFont(primaryFontPath, 18);
        Label songArtist = createLabel(song.getArtistName(), sonArtistFont, "#C0C0C0");

        //  Votes
        Font votesFont = loadFont(primaryFontPath, 30);
        VotesBox votesBox = new VotesBox(song.getTotalUpVotes(), song.getTotalDownVotes(), votesFont);

        //  Album Name
        StackPane albumPane = new InfoRec(paneContentWidth, 70, "Album", song.getAlbumName()).getInfoRec();

        //  Genre
        StackPane genrePane = new InfoRec(paneContentWidth, 70, "Género", song.getMusicGenre()).getInfoRec();

        //  MP3 Reference
        Font referenceButtonFont = loadFont(buttonFontPath, 16);
        Button referenceButton = createReferenceButton(referenceButtonFont, song.getFilePath());

        //  Song Info Box
        VBox songInfoBox = new VBox(10);
        songInfoBox.getChildren().addAll(songName, songArtist, votesBox.getVotesBox(), albumPane, genrePane, referenceButton);

        //  Add elements to the main pane
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

    /**
     * Creates a label with the specified text, font, and text color.
     *
     * @param text      The text to be displayed on the label.
     * @param font      The font for the label text.
     * @param textColor The color of the label text.
     * @return The created label.
     */
    private Label createLabel(String text, Font font, String textColor) {
        Label label = new Label(text);
        label.setStyle("-fx-text-fill: " + textColor + ";");
        label.setFont(font);
        return label;
    }

    /**
     * Creates a button for opening the file explorer at the specified file path.
     *
     * @param font     The font for the button text.
     * @param filePath The path to the file to be opened in the file explorer.
     * @return The created reference button.
     */
    private Button createReferenceButton(Font font, String filePath) {
        Button referenceButton = new Button("Ir al MP3");
        referenceButton.getStyleClass().add("reference-button");
        referenceButton.setFont(font);

        // Functionality
        referenceButton.setOnAction(event -> openFileExplorer(filePath));

        return referenceButton;
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

    /**
     * Loads a font from the specified font path with the given font size.
     *
     * @param fontPath The path to the font file.
     * @param fontSize The size of the font to load.
     * @return The loaded Font object.
     */
    private Font loadFont(String fontPath, double fontSize) {
        return Font.loadFont(getClass().getResourceAsStream(fontPath), fontSize);
    }

}