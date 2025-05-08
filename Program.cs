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
            DataBaseHandler database = new();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form_Login(database));
        }
    }
}
