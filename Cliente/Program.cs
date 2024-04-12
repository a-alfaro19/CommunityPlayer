using System;
using System.Net.Sockets;
using Microsoft.Extensions.Logging;
using System.Windows.Forms;

namespace ClientGUI
{
    class Program
    {
    private static readonly ILogger logger;

    static Program()
    {
        var loggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddConsole();
        });

        logger = loggerFactory.CreateLogger(nameof(Program));
    }

    [STAThread]
    static void Main()
    {
        int serverPort; 

        try
        {
            string IniFilePath = "config.ini";

            IniFile iniFile = new IniFile(IniFilePath);

            serverPort = int.Parse(iniFile.Read("Client", "PORT", "4343")); 

            Console.WriteLine("Port: " + serverPort);

            Client client = new Client();
            client.Connect(serverPort);
            /*while (true)
            {
                client.SendMessage("Get-Playlist");
                string response = client.ReceiveMessages();
                Console.WriteLine(response);
                break;
            }*/
            client.Disconnect();
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Ocurrió un error no manejado en la aplicación");
            throw;
        }

        try
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm(serverPort));
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Ocurrió un error no manejado en la aplicación");
            throw;
        }
        finally
        {
            logger.LogInformation("La aplicación ha finalizado");
        }
    }
    }
}
