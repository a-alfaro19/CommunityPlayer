package com.example.communityplayer;

import com.example.communityplayer.ui.SongInfoSection;
import javafx.application.Application;
import javafx.scene.Scene;
import javafx.scene.image.Image;
import javafx.scene.layout.HBox;
import javafx.stage.Stage;

import java.io.IOException;
import java.util.Objects;

public class HelloApplication extends Application {
    private final double[] size = new double[] {1350, 800};

    @Override
    public void start(Stage stage) throws IOException {
        ConfigFileLoader configFileLoader = new ConfigFileLoader("C:/Users/andre/OneDrive/Documents/GitHub/CommunityPlayer/CommunityPlayer/src/main/resources/com/example/communityplayer/config.ini");
        MP3MetadataExtractor extractor = new MP3MetadataExtractor(configFileLoader.getPath());

        int padding = 15;

        Song song = extractor.getSongList().get(0);

        SongInfoSection songInfoSection = new SongInfoSection(song, size, padding);

        HBox root = new HBox();
        root.setStyle("-fx-background-color: #000000");
        root.setPrefSize(getRootWidth(), getRootHeight());
        root.getChildren().addAll(songInfoSection.getPane());
        root.setPadding(new javafx.geometry.Insets(padding));

        Scene scene = new Scene(root, getRootWidth(), getRootHeight());
        scene.getStylesheets().add(Objects.requireNonNull(getClass().getResource("styles.css")).toExternalForm());

        stage.setTitle("Community Player");
        Image icon = new Image(Objects.requireNonNull(getClass().getResource("images/app-logo.png")).toExternalForm());
        stage.getIcons().add(icon);

        stage.setScene(scene);
        stage.show();
    }

    public double getRootWidth() {
        return size[0];
    }

    public double getRootHeight() {
        return size[1];
    }

    public static void main(String[] args) {
        launch();
    }
}