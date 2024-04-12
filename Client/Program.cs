using System;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Threading;
using Microsoft.Extensions.Logging;

namespace CommunityClient
{
    static class Program 
    {
        [STAThread]
        static void Main(string[] args) 
        {
            string serverIpAddress = "192.168.1.7";
            int serverPort = 4343; // Puerto 4343

            string IniFilePath = "config.ini";
            IniFile iniFile = new IniFile(IniFilePath);

            serverPort = int.Parse(iniFile.Read("Client", "PORT", "4343")); 

            var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder.AddConsole();
            });

            var logger = loggerFactory.CreateLogger(typeof(Program));
            var clientLogger = loggerFactory.CreateLogger<Client>();
            var formLogger = loggerFactory.CreateLogger<MainForm>();

            try
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new MainForm(formLogger, clientLogger));

                var client = new Client(clientLogger);
                client.Connect(serverPort, serverIpAddress);

                client.SendMessage("Get-Playlist");
                string response = client.ReceiveMessage();
                Console.WriteLine(response);
                Thread.Sleep(1000);

                client.Disconnect();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "An error occurred in the main program");
            }
        }
    }
}