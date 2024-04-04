package com.example.communityplayer;

import com.example.communityplayer.ds.DoubleLinkedList;
import com.example.communityplayer.ds.iterator.Iterator;

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

    public String toString() {
        StringBuilder sb = new StringBuilder();
        sb.append("[");
        Iterator<Song> iterator = createIterator();
        while (iterator.hasNext()) {
            sb.append(iterator.next().data.toString());
        }
        sb.append("]");

        return sb.toString();
    }

}
