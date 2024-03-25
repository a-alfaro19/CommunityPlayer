module com.example.communityplayer {
    requires javafx.controls;
    requires javafx.fxml;
    requires java.desktop;
    requires jaudiotagger;
    requires ini4j;
    requires java.prefs;
    requires com.google.gson;


    opens com.example.communityplayer to javafx.fxml;
    exports com.example.communityplayer;
    exports com.example.communityplayer.ds;
    opens com.example.communityplayer.ds to javafx.fxml;
    exports com.example.communityplayer.ds.iterator;
    opens com.example.communityplayer.ds.iterator to javafx.fxml;
    exports com.example.communityplayer.json;
    opens com.example.communityplayer.json to javafx.fxml;
    exports com.example.communityplayer.server;
    opens com.example.communityplayer.server to javafx.fxml;
    exports com.example.communityplayer.controllers;
    opens com.example.communityplayer.controllers to javafx.fxml;

}