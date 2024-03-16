package com.example.communityplayer;

import org.ini4j.Ini;
import org.ini4j.IniPreferences;
import java.util.prefs.Preferences;

import java.io.File;
import java.io.IOException;

/**
 * The ConfigFileLoader class is responsible for loading configuration settings from an INI file.
 */
public class ConfigFileLoader {
    private final int port;
    private final String path;

    /**
     * Constructs a ConfigFileLoader object with the specified file path.
     *
     * @param filePath The path to the INI configuration file.
     * @throws IOException If an I/O error occurs while reading the file.
     */
    public ConfigFileLoader(String filePath) throws IOException {
        Ini iniConfig = new Ini(new File(filePath)); // Load the INI file
        Preferences prefs = new IniPreferences(iniConfig); // Create preferences from the INI file

        // Retrieve values from the INI file
        port = prefs.node("Server").getInt("PORT", -1); // Default value is -1 if not found
        path = prefs.node("Server").get("LIBRARY_PATH", ""); // Default value is an empty string if not found

    }

    /**
     * Gets the port number read from the configuration file.
     *
     * @return The port number.
     */
    public int getPort() {
        return port;
    }

    /**
     * Gets the path read from the configuration file.
     *
     * @return The path.
     */
    public String getPath() {
        return path;
    }

}
