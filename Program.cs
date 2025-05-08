namespace InkPos
{
    internal class Program
    {

        [STAThread]
        static void Main()
        {
            DataBaseHandler database = new();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form_Ventana_Pago(database));
        }
    }
}