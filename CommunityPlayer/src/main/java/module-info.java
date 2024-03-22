module com.example.communityplayer {
    requires javafx.controls;
    requires javafx.fxml;
    requires java.desktop;
    requires jaudiotagger;
    requires ini4j;
    requires java.prefs;


    opens com.example.communityplayer to javafx.fxml;
    exports com.example.communityplayer;
    exports com.example.communityplayer.ui.components;
    opens com.example.communityplayer.ui.components to javafx.fxml;
    exports com.example.communityplayer.ui;
    opens com.example.communityplayer.ui to javafx.fxml;
}