module com.example.communityplayer {
    requires javafx.controls;
    requires javafx.fxml;


    opens com.example.communityplayer to javafx.fxml;
    exports com.example.communityplayer;
}