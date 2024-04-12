using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace CommunityClient {
    public class Client {
        private Socket clientSocket;

        public Client() {
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void Connect(int port, string ipAddress) {
            clientSocket.Connect(new IPEndPoint(IPAddress.Parse(ipAddress), port));
            Console.WriteLine("Connected to server at " + ipAddress + ":" + port);
        }

        public void Disconnect() {
            try {
                clientSocket.Shutdown(SocketShutdown.Both);
                clientSocket.Close();

            } catch (Exception e) {
                Console.WriteLine("Error al desconectar del servidor: " + e.Message);
            }
        }

        public void SendMessage(string command, string songId="") {
            try {
                string message = "{" +
                    "\"command\": \"" + command + "\"" +
                    ", \"id\": \"" + songId + "\"" +
                "}";
                byte[] messageBytes = Encoding.UTF8.GetBytes(message);
                int messageLen = messageBytes.Length;
                byte[] messageLenBytes = BitConverter.GetBytes(messageLen);
                clientSocket.Send(messageLenBytes);
                clientSocket.Send(messageBytes);

            } catch (Exception e) {
                Console.WriteLine("Error al enviar mensaje al servidor: " + e.Message);
            }
        }

        public string ReceiveMessage() {
            byte[] responseLenBytes = new byte[4];
            clientSocket.Receive(responseLenBytes);
            int responseLen = BitConverter.ToInt32(responseLenBytes, 0);
            byte[] responseBytes = new byte[responseLen];
            clientSocket.Receive(responseBytes);
            string response = Encoding.UTF8.GetString(responseBytes);
            Console.WriteLine("Server response: " + response);

            return response;
        }
    }
}
