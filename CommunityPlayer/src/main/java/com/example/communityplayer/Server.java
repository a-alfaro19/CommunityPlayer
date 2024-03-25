package com.example.communityplayer;

import java.io.*;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.UUID;

import com.example.communityplayer.Song;
import com.example.communityplayer.SongPlaylist;
import com.example.communityplayer.controllers.SongInfoController;
import com.example.communityplayer.json.JsonRequest;
import com.example.communityplayer.json.JsonRequestTypeAdapter;
import com.google.gson.Gson;
import com.google.gson.GsonBuilder;

public class Server {
    private final SongPlaylist playlist;
    private ServerSocket serverSocket;
    private Socket socket;
    private BufferedReader bufferedReader;
    private BufferedWriter bufferedWriter;

    public Server(ServerSocket serverSocket, SongPlaylist playlist) {
        this.playlist = playlist;
        this.serverSocket = serverSocket;
    }

    public void start() {
        try {
            System.out.println("Server started");
            socket = serverSocket.accept();
            System.out.println("Client accepted");
            bufferedReader = new BufferedReader(new InputStreamReader(socket.getInputStream()));
            bufferedWriter = new BufferedWriter(new OutputStreamWriter(socket.getOutputStream()));

        } catch (Exception e) {
            e.printStackTrace();
            close(socket, bufferedReader, bufferedWriter);
        }
    }

    public void close(Socket socket, BufferedReader bufferedReader, BufferedWriter bufferedWriter) {
        try {
            if (bufferedReader != null) {
                bufferedReader.close();
            }
            if (bufferedWriter != null) {
                bufferedWriter.close();
            }
            if (socket != null) {
                socket.close();
            }

        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public void sendResponse(String response) {
        try {
            bufferedWriter.write(response);
            bufferedWriter.newLine();
            bufferedWriter.flush();

        } catch (Exception e) {
            e.printStackTrace();
            close(socket, bufferedReader, bufferedWriter);
        }
    }

    public void receiveRequest(SongInfoController songInfoController) {
        new Thread(new Runnable() {
            @Override
            public void run() {
                while (socket.isConnected()) {
                    try {
                        String request = bufferedReader.readLine();
                        processRequest(request, songInfoController);

                    } catch (Exception e) {
                        e.printStackTrace();
                        close(socket, bufferedReader, bufferedWriter);
                        break;
                    }
                }
            }
        }).start();
    }

    private void processRequest(String request, SongInfoController songInfoController) {
        String response = "";

        JsonRequest jsonRequest = parseJSON(request);

        String command = jsonRequest.command;
        System.out.println(command);
        String songId = jsonRequest.songId;

        Song song;
        if (songId != null) {
            song = playlist.getById(UUID.fromString(songId));

        } else {
            song = null;
        }

        switch (command) {
            case "Get-Playlist":
                System.out.println("Getting Playlist");
                break;

            case "Vote-up":
                if (songId != null) {
                    song.voteUp();
                    songInfoController.totalUpVotes.setText(String.valueOf(song.getTotalUpVotes()));
                    System.out.println("Voted Up: " + song.getTotalUpVotes());
                    response = "OK";
                }
                break;

            case "Vote-down":
                if (songId != null) {
                    song.voteDown();
                    songInfoController.totalDownVotes.setText(String.valueOf(song.getTotalDownVotes()));
                    System.out.println("Voted Down: " + song.getTotalDownVotes());
                    response = "OK";
                }
                break;

            default:
                System.out.println("Comando desconocido: " + command);
                response = "ERROR";
                break;

        }

        sendResponse(response);

    }

    private JsonRequest parseJSON(String json) {
        Gson gson = new GsonBuilder().registerTypeAdapter(JsonRequest.class, new JsonRequestTypeAdapter()).create();
        return gson.fromJson(json, JsonRequest.class);
    }

}

