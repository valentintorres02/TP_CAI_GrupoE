using TP_CAI.Forms.InicioDeSesion.Forms;
using TP_CAI.Forms.PantallaPrincipal.Forms;

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
                
            InicioDeSesionForm inicioDeSesionForm = new InicioDeSesionForm();

            if (inicioDeSesionForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new PantallaPrincipalForm(inicioDeSesionForm.usuario));
            }
        }
    }
}