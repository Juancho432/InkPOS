using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace InkPos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Evento que se llama cuando el formulario se carga
        private void Form1_Load(object sender, EventArgs e)
        {
            // Obtener la ruta del directorio donde se encuentra el ejecutable
            string appDirectory = Application.StartupPath;

            // Ruta relativa a los archivos .bat en la raíz del proyecto
            string startBatPath = Path.Combine(appDirectory, "start_pg.bat");

            try
            {
                // Ejecuta start_pg.bat para iniciar PostgreSQL
                Process.Start(startBatPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar PostgreSQL: " + ex.Message);
            }

            // Mostrar el formulario de prueba de conexión
            FormPruebaDB formConexion = new FormPruebaDB();
            formConexion.ShowDialog();
        }

        // Evento que se llama cuando el formulario se va a cerrar
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Obtener la ruta del directorio donde se encuentra el ejecutable
            string appDirectory = Application.StartupPath;

            // Ruta relativa a los archivos .bat en la raíz del proyecto
            string stopBatPath = Path.Combine(appDirectory, "stop_pg.bat");

            try
            {
                // Ejecuta stop_pg.bat para detener PostgreSQL
                Process.Start(stopBatPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al detener PostgreSQL: " + ex.Message);
            }
        }
    }
}
