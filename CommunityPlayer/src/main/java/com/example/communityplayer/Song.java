package com.example.communityplayer;

/**
 * A class representing a song.
 */
public class Song {
    private final String id;
    private final String songName;
    private final String artistName;
    private final String albumName;
    private final String musicGenre;
    private int totalUpVotes;
    private int totalDownVotes;
    private final String filePath;
    private final String imagePath;

    /**
     * Constructs a Song object with the specified parameters.
     *
     * @param id          The unique identifier of the song.
     * @param songName    The name of the song.
     * @param artistName  The name of the artist.
     * @param albumName   The name of the album.
     * @param musicGenre  The genre of the music.
     * @param filePath    The file path of the song.
     * @param imagePath   The file path of the song's image.
     */
    public Song(String id, String songName, String artistName, String albumName, String musicGenre, String filePath, String imagePath) {
        this.id = id;
        this.songName = songName;
        this.artistName = artistName;
        this.albumName = albumName;
        this.musicGenre = musicGenre;
        this.filePath = filePath;
        this.imagePath = imagePath;
    }

    /**
     * Gets the ID of the song.
     *
     * @return The ID.
     */
    public String getId() {
        return id;
    }

    /**
     * Gets the name of the song.
     *
     * @return The song name.
     */
    public String getSongName() {
        return songName;
    }

    /**
     * Gets the name of the artist.
     *
     * @return The artist name.
     */
    public String getArtistName() {
        return artistName;
    }

    /**
     * Gets the name of the album.
     *
     * @return The album name.
     */
    public String getAlbumName() {
        return albumName;
    }

    /**
     * Gets the genre of the music.
     *
     * @return The music genre.
     */
    public String getMusicGenre() { return musicGenre; }

    /**
     * Gets the total number of up votes for the song.
     *
     * @return The total up votes.
     */
    public int getTotalUpVotes() {
        return totalUpVotes;
    }

    /**
     * Gets the total number of down votes for the song.
     *
     * @return The total down votes.
     */
    public int getTotalDownVotes() {
        return totalDownVotes;
    }

    /**
     * Gets the file path of the song.
     *
     * @return The file path.
     */
    public String getFilePath() {
        return filePath;
    }

    /**
     * Gets the file path of the song's image.
     *
     * @return The image file path.
     */
    public String getImagePath() { return imagePath; }

    /**
     * Sets the total number of up votes for the song.
     *
     * @param votes The new total number of up votes to set.
     */
    public void setTotalUpVotes(int votes) {
        totalUpVotes = votes;
    }

    /**
     * Sets the total number of down votes for the song.
     *
     * @param votes The new total number of down votes to set.
     */
    public void setTotalDownVotes(int votes) {
        totalDownVotes = votes;
    }

}
