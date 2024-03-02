package com.example.communityplayer;

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
        int padding = 15;

        Song song = new Song("0", "Perfect", "Ed Sheeran", "Divide", "Baladas", "./", "images/divide.jpg");

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