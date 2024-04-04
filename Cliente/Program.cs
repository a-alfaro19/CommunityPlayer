using System.Net.Sockets;

class Program
{
    
    [STAThread]
    static void Main()
    {
        // var loggerFactory = LoggerFactory.Create(builder =>
        // {
        //     builder.AddConsole();
        // });

        // var logger = loggerFactory.CreateLogger(nameof(Program));

        try {
            string IniFilePath = "config.ini";

            IniFile iniFile = new IniFile(IniFilePath);

            int port = int.Parse(iniFile.Read("Client", "PORT", "4343"));

            Console.WriteLine("Port: " + port);

            Client client = new Client();
            client.Connect(port);
            while(true) {
                client.SendMessage("Get-Playlist");
                string response = client.ReceiveMessages();
                Console.WriteLine(response);
                break;
            }
            client.Disconnect();
            

            


        } catch (Exception ex) {
            // logger.LogError(ex, "Ocurrió un error no manejado en la aplicación");
            throw;
        }

        // try
        // {
        //     ApplicationConfiguration.Initialize();
        //     Application.Run(new Form1());
        // }
        // catch (Exception ex)
        // {
        //     logger.LogError(ex, "Ocurrió un error no manejado en la aplicación");
        //     throw;
        // }
        // finally
        // {
        //     logger.LogInformation("La aplicación ha finalizado");
        // }
    }    
}
