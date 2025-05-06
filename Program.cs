using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace InkPos
{
    internal class Program
    {
        [STAThread]
        static void Main()
        {
            // Ruta al archivo .bat (se debe copiar al directorio de salida)
            string rutaStart = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "start_pg.bat");
            string rutaStop = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "stop_pg.bat");

           
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = rutaStart,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden
                };
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar start_pg.bat: " + ex.Message);
            }

            // Registrar evento de salida para ejecutar stop_pg.bat
            Application.ApplicationExit += (sender, e) =>
            {
                try
                {
                    ProcessStartInfo stopInfo = new ProcessStartInfo
                    {
                        FileName = rutaStop,
                        UseShellExecute = false,
                        CreateNoWindow = true,
                        WindowStyle = ProcessWindowStyle.Hidden
                    };
                    Process.Start(stopInfo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ejecutar stop_pg.bat: " + ex.Message);
                }
            };

            // Iniciar la aplicación
            ApplicationConfiguration.Initialize();
            Application.Run(new menu_opciones_admin());
        }
    }
}
