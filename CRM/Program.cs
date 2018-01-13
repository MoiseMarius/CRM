using System;
using System.Windows.Forms;

namespace CRM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Autentificare());
            if (Autentificare.LoggedIn)
            {
                Application.Run(new PaginaPrincipala());
            }
        }
    }
}
