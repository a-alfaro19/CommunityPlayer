package com.example.communityplayer;

import com.example.communityplayer.ds.CustomList;
import com.example.communityplayer.ds.DoubleLinkedList;
import com.example.communityplayer.ds.iterator.Iterator;

import java.time.Duration;
import java.util.ArrayList;
import java.util.List;
import java.util.UUID;

public class SongPlaylist extends DoubleLinkedList<Song> {

    public Song getById(UUID id) {
        Iterator<Song> iterator = createIterator();
        while (iterator.hasNext()) {
            Song song = iterator.next().data;
            UUID songId = UUID.fromString(song.getId());
            if (songId.equals(id)) {
                return song;
            }
        }
        return null;

    }

    public CustomList<Song> getSongsByArtist(String artistName) {
        CustomList<Song> artistSongs = new CustomList<>();
        Iterator<Song> iterator = createIterator();
        while (iterator.hasNext()) {
            Song song = iterator.next().data;
            if (song.getArtistName().equalsIgnoreCase(artistName)) {
                artistSongs.add(song);
            }
        }
        return artistSongs;
    }

    public Song getSongByName(String songName) {
        Iterator<Song> iterator = createIterator();
        while (iterator.hasNext()) {
            Song song = iterator.next().data;
            if (song.getSongName().equalsIgnoreCase(songName)) {
                return song;
            }
        }
        return null;
    }
}
