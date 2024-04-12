using System;

namespace CommunityClient
{
    class Program {

        static void Main(string[] args) {
            string serverIpAddress = "192.168.1.7"; // Change to the server's IP address
            int serverPort = 4343; // Port 4343

            Client client = new Client();
            client.Connect(serverPort, serverIpAddress);

            while(true) {
                Console.Write("Enter a message (type 'exit' to quit): ");
                string message = Console.ReadLine();

                if (message.ToLower() == "exit") {
                    break; // Exit the loop
                }

                client.SendMessage(message);

                string response = client.ReceiveMessage();

                Console.WriteLine("Server response: " + response);
            }
            client.Disconnect();
        }
    }
}