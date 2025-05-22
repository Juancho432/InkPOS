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
            Empleado empleado = new Empleado("1", "sebas", "212", true, 11111111);
            DataBaseHandler database = new DataBaseHandler();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form_Gestion_Productos(empleado, database));
        }
    }
}
