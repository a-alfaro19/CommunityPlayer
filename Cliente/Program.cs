using Microsoft.Extensions.Logging;

namespace Cliente
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder.AddConsole();
            });

            var logger = loggerFactory.CreateLogger(typeof(Program).FullName);

            try
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new Form1());
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
