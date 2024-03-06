module com.example.communityplayer {
    requires javafx.controls;
    requires javafx.fxml;
    requires java.desktop;


    opens com.example.communityplayer to javafx.fxml;
    exports com.example.communityplayer;
    exports com.example.communityplayer.components;
    opens com.example.communityplayer.components to javafx.fxml;
}