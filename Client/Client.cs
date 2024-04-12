using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using Microsoft.Extensions.Logging;

namespace CommunityClient
{
    public class Client
    {
        private readonly Socket clientSocket;
        private readonly ILogger<Client> clientLogger;

        public Client(ILogger<Client> clientLogger)
        {
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            this.clientLogger = clientLogger;
        }

        public void Connect(int port, string ipAddress)
        {
            try
            {
                clientSocket.Connect(new IPEndPoint(IPAddress.Parse(ipAddress), port));
                clientLogger.LogInformation("Connected to server at {IpAddress}:{Port}", ipAddress, port);
            }
            catch (Exception ex)
            {
                clientLogger.LogError(ex, "Error connecting to server");
            }
        }

        public void Disconnect()
        {
            try
            {
                clientSocket.Shutdown(SocketShutdown.Both);
                clientSocket.Close();
                clientLogger.LogInformation("Disconnected from server");
            }
            catch (Exception ex)
            {
                clientLogger.LogError(ex, "Error disconnecting from server");
            }
        }

        public void SendMessage(string command, string songId = "")
        {
            try
            {
                string message = "{" +
                                 "\"command\": \"" + command + "\"" +
                                 ", \"id\": \"" + songId + "\"" +
                                 "}";
                byte[] messageBytes = Encoding.UTF8.GetBytes(message);
                int messageLen = messageBytes.Length;
                byte[] messageLenBytes = BitConverter.GetBytes(messageLen);
                clientSocket.Send(messageLenBytes);
                clientSocket.Send(messageBytes);
            }
            catch (Exception ex)
            {
                clientLogger.LogError(ex, "Error sending message to server");
            }
        }

        public string ReceiveMessage()
        {
            try
            {
                byte[] responseLenBytes = new byte[4];
                clientSocket.Receive(responseLenBytes);
                int responseLen = BitConverter.ToInt32(responseLenBytes, 0);
                byte[] responseBytes = new byte[responseLen];
                clientSocket.Receive(responseBytes);
                string response = Encoding.UTF8.GetString(responseBytes);
                clientLogger.LogInformation("Server response: {Response}", response);
                return response;
            }
            catch (Exception ex)
            {
                clientLogger.LogError(ex, "Error receiving message from server");
                return null;
            }
        }
    }
}

