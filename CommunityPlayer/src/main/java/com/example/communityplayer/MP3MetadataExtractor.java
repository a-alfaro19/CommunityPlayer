package com.example.communityplayer;

import org.jaudiotagger.audio.AudioFile;
import org.jaudiotagger.audio.AudioFileIO;
import org.jaudiotagger.tag.FieldKey;
import org.jaudiotagger.tag.Tag;
import org.jaudiotagger.tag.datatype.Artwork;

import java.io.File;
import java.util.ArrayList;
import java.util.List;
import java.util.UUID;

/**
 * The MP3MetadataExtractor class is used to extract metadata from MP3 files in a specific directory.
 */
public class MP3MetadataExtractor {
    // List to store song metadata
    private DoubleLinkedList<Song> songList;

    /**
     * Constructor for the MP3MetadataExtractor class.
     * @param libraryPath Path to the directory containing the MP3 files.
     */
    public MP3MetadataExtractor(String libraryPath) {
        // Read MP3 files from the specified directory
        File[] mp3Files = readDirectory(libraryPath);

        try {
            // Initialize the song list
            songList = new DoubleLinkedList<>();

            // Iterate through MP3 files and extract their metadata
            for (File file : mp3Files) {
                AudioFile audioFile = AudioFileIO.read(file);
                Tag tag = audioFile.getTag();

                // Get song metadata
                String key = UUID.randomUUID().toString();
                String title = tag.getFirst(FieldKey.TITLE);
                String artist = tag.getFirst(FieldKey.ARTIST);
                String album = tag.getFirst(FieldKey.ALBUM);
                String genre = tag.getFirst(FieldKey.GENRE);
                String absolutePath = file.getAbsolutePath();
                Artwork artwork = tag.getFirstArtwork();

                // Check if any metadata is empty and set a default value in that case
                if (key.isEmpty()) {
                    key = "No se consiguió información";
                }
                if (title.isEmpty()) {
                    title = "No se consiguió información";
                }
                if (artist.isEmpty()) {
                    artist = "No se consiguió información";
                }
                if (album.isEmpty()) {
                    album = "No se consiguió información";
                }
                if (genre.isEmpty()) {
                    genre = "No se consiguió información";
                }

                // Create a Song object with the extracted metadata and add it to the song list
                Song song = new Song(key, title, artist, album, genre, absolutePath, artwork);
                songList.add(song);
            }

        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    /**
     * Private method to read MP3 files from a directory.
     * @param path Directory path.
     * @return Array of File objects representing the MP3 files in the directory.
     */
    private File[] readDirectory(String path) {
        try {
            File library = new File(path);

            // Check if the specified path is a valid directory
            if (library.exists() && library.isDirectory()) {
                List<File> mp3FilesList = new ArrayList<>();
                File[] files = library.listFiles();
                assert files != null;

                // Filter files to get only MP3 files
                for (File file : files) {
                    if (file.isFile() && file.getName().toLowerCase().endsWith(".mp3")) {
                        mp3FilesList.add(file);
                    }
                }

                return mp3FilesList.toArray(new File[0]);

            } else {
                System.out.println("El directorio especificado no existe o no es un directorio válido.");
            }
        } catch (Exception e) {
            e.printStackTrace();
        }

        return new File[0];
    }

    /**
     * Method to get the list of songs.
     * @return List of songs.
     */
    public DoubleLinkedList<Song> getSongList() {
        return songList;
    }
}
