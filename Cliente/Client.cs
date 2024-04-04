using System.Net;
using System.Net.Sockets;
using System.Text;
using Accessibility;

public class Client {
    private Socket clientSocket;

    public void Connect(int port) {
        IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
        IPAddress ipAddr = ipHost.AddressList[0];
        IPEndPoint localEndPoint = new IPEndPoint(ipAddr, port);

        clientSocket = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

        try {
            clientSocket.Connect(localEndPoint);

            Console.WriteLine("Socket connected to -> {0} ", clientSocket.RemoteEndPoint.ToString());

        } catch (Exception e) {
            Console.WriteLine("Error al conectar con el servidor: " + e.Message);
        }
    }

    public void Disconnect() {
        try {
            clientSocket.Shutdown(SocketShutdown.Both);
            clientSocket.Close();

        } catch (Exception e) {
            Console.WriteLine("Error al desconectar del servidor: " + e.Message);
        }
    }

    public void SendMessage(string message) {
        try {
            byte[] messageBytes = Encoding.UTF8.GetBytes(message);
            int messageLen = messageBytes.Length;
            byte[] messageLenBytes = BitConverter.GetBytes(messageLen);
            clientSocket.Send(messageLenBytes);
            clientSocket.Send(messageBytes);

        } catch (Exception e) {
            Console.WriteLine("Error al enviar mensaje al servidor: " + e.Message);
        }
    }

    public string ReceiveMessages() {
        byte[] responseLenBytes = new byte[4];
        clientSocket.Receive(responseLenBytes);
        int responseLen = BitConverter.ToInt32(responseLenBytes, 0);
        byte[] responseBytes = new byte[responseLen];
        clientSocket.Receive(responseBytes);
        string response = Encoding.UTF8.GetString(responseBytes);
        Console.WriteLine("Server response: " + response);

        return response;
    }

    public string getPlaylist() {
        SendMessage("Get-Playlist");
        return ReceiveMessages();
    }

}