using TP_CAI.Almacenes;
using TP_CAI.Archivos.PantallaPrincipal.Forms;

namespace TP_CAI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();


            Application.Run(new PantallaPrincipalForm());
            ClienteAlmacen.Grabar();
            DepositosAlmacen.Grabar();
            MercaderiaAlmacen.Grabar();
            OrdenPreparacionAlmacen.Grabar();
            OrdenSeleccionAlmacen.Grabar();
        }
    }
}