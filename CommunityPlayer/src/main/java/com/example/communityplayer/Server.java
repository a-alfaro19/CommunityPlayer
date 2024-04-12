package com.example.communityplayer;

import java.io.*;
import java.net.InetAddress;
import java.net.ServerSocket;
import java.net.Socket;

public class Server {
    private final ServerSocket serverSocket;
    private Socket socket;

    public Server(ServerSocket serverSocket) {
        this.serverSocket = serverSocket;
    }

    public void listen() {
        try {
            socket = serverSocket.accept();
            System.out.println("Client connected: " + socket.getInetAddress());

        } catch (Exception e) {
            System.out.println("Error corriendo el servidor.");
            e.printStackTrace();
            close();
        }
    }

    public void close() {
        try {
            if (socket != null) {
                socket.close();
            }

        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public void sendResponse(String response) {
        try {
            OutputStream outputStream = socket.getOutputStream();

            byte[] bytesToSend = response.getBytes();
            int toSendLen = bytesToSend.length;
            byte[] toSendLenBytes = new byte[4];
            toSendLenBytes[0] = (byte) (toSendLen & 0xff);
            toSendLenBytes[1] = (byte) ((toSendLen >> 8) & 0xff);
            toSendLenBytes[2] = (byte) ((toSendLen >> 16) & 0xff);
            toSendLenBytes[3] = (byte) ((toSendLen >> 24) & 0xff);

            outputStream.write(toSendLenBytes);
            outputStream.write(bytesToSend);

        } catch (Exception e) {
            System.out.println("Error enviando respuesta.");
            e.printStackTrace();
            close();
        }
    }

    public String receiveRequest() {
        String received = "";
        try {
            InputStream inputStream = socket.getInputStream();

            byte[] lenBytes = new byte[4];
            inputStream.read(lenBytes, 0, 4);
            int len = (((lenBytes[3] & 0xff) << 24) | ((lenBytes[2] & 0xff) << 16) |
                    ((lenBytes[1] & 0xff) << 8) | (lenBytes[0] & 0xff));
            byte[] receivedBytes = new byte[len];
            inputStream.read(receivedBytes, 0, len);
            received = new String(receivedBytes, 0, len);
            System.out.println("Server received: " + received);

            return received;

        } catch (Exception e) {
            System.err.println("Error en la conexion: " + e.getMessage());
//            e.printStackTrace();
            close();
            return received;
        }
    }

}

//TODO: Coordinar mutex del server
