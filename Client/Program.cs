using System;
using System.Net.Sockets;
//using Microsoft.Extensions.Logging;
using System.Windows.Forms;

namespace CommunityClient
{
    static class Program 
    {
        [STAThread]
        static void Main(string[] args) 
        {
            string serverIpAddress = "192.168.1.7";
            int serverPort = 4343; // Port 4343

            string IniFilePath = "config.ini";

            IniFile iniFile = new IniFile(IniFilePath);

            serverPort = int.Parse(iniFile.Read("Client", "PORT", "4343")); 

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());

            Client client = new Client();
            client.Connect(serverPort, serverIpAddress);

            while (true)
            {
                client.SendMessage("Get-Playlist");
                string response = client.ReceiveMessage();
                Console.WriteLine(response);
                Thread.Sleep(1000);
                break;
            }

            client.Disconnect();
        }
    }
}