package com.example.communityplayer;

import com.example.communityplayer.controllers.AppController;
import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.image.Image;
import javafx.scene.text.Font;
import javafx.stage.Stage;

import java.io.IOException;
import java.util.Objects;

public class App extends Application {

    @Override
    public void start(Stage stage) throws IOException {

        // Fonts
        loadFont("fonts/Gotham-Bold.otf");
        loadFont("fonts/GothamMedium.ttf");
        loadFont("Gotham-Font/Gotham-Black.otf");


        // Load FXML file
        FXMLLoader loader = new FXMLLoader(getClass().getResource("controllers/app.fxml"));
        Parent root = loader.load();

        // Load Controller
        AppController controller = loader.getController();

        Scene scene = new Scene(root, 1350, 800);

        // Load CSS styles file
        scene.getStylesheets().add(Objects.requireNonNull(getClass().getResource("styles.css")).toExternalForm());

        stage.setScene(scene);
        stage.setTitle("Community Player");
        Image icon = new Image(Objects.requireNonNull(getClass().getResource("images/app-logo.png")).toExternalForm());
        stage.getIcons().add(icon);

        stage.show();

    }

    /**
     * Loads a font from the specified font path with the given font size.
     *
     * @param fontPath The path to the font file.
     */
    private void loadFont(String fontPath) {
        Font.loadFont(getClass().getResourceAsStream(fontPath), 18);
    }

    public static void main(String[] args) {
        launch();
    }
}