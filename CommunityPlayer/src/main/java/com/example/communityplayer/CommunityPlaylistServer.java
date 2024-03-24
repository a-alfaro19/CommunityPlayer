package com.example.communityplayer;

import java.io.*;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.UUID;

import com.example.communityplayer.json.JsonRequest;
import com.example.communityplayer.json.JsonRequestTypeAdapter;
import com.google.gson.Gson;
import com.google.gson.GsonBuilder;

public class CommunityPlaylistServer {
    private final int port;

    private final SongPlaylist playlist;

    public CommunityPlaylistServer(int port, SongPlaylist playlist) {
        this.port = port;
        this.playlist = playlist;
    }

    public void start() {
        try {
            ServerSocket server = new ServerSocket(port);
            System.out.println("Server started");

            System.out.println("Waiting for a client ...");

            while (true) {
                Socket clientSocket = server.accept();
                System.out.println("Client accepted");

                Thread thread = new Thread(() -> {
                    try {
                        processRequest(clientSocket);
                    } catch (IOException e) {
                        e.printStackTrace();
                    }
                });
                thread.start();

            }

        } catch (IOException i) {
            System.out.println(i);
        }
    }

    private JsonRequest parseJSON(String json) {
        Gson gson = new GsonBuilder().registerTypeAdapter(JsonRequest.class, new JsonRequestTypeAdapter()).create();
        return gson.fromJson(json, JsonRequest.class);
    }

    private void processRequest(Socket clientSocket) throws IOException {
        try (clientSocket;
            BufferedReader reader = new BufferedReader(new InputStreamReader(clientSocket.getInputStream()));
            OutputStream outputStream = clientSocket.getOutputStream();
            PrintWriter writer = new PrintWriter(new OutputStreamWriter(outputStream), true)) {

            StringBuilder jsonBuilder = new StringBuilder();
            String line;

            while ((line = reader.readLine()) != null) {
                jsonBuilder.append(line);
            }

            JsonRequest request = parseJSON(jsonBuilder.toString());
            System.out.println("ID del Cliente: " + request.songId);
            System.out.println("Comando a Enviar: " + request.command);

            String command = request.command;
            Song song = playlist.getById(UUID.fromString(request.songId));

            String response = "";

            switch (command) {
                case "Get-Playlist":
                    System.out.println("Getting Playlist");
                    break;

                case "Vote-up":
                    if (song != null) {
                        song.setTotalUpVotes(song.getTotalUpVotes() + 1);
                        response = "OK";
                        System.out.println("Voted Up: " + song.getTotalUpVotes());
                    }
                    break;

                case "Vote-down":
                    if (song != null) {
                        song.setTotalDownVotes(song.getTotalDownVotes() + 1);
                        response = "OK";
                        System.out.println("Voted Down " + song.getTotalUpVotes());
                    }
                    break;

                default:
                    System.out.println("Comando desconocido: " + command);
                    response = "ERROR";
                    break;

            }
            writer.println(response);

        }

    }

}
