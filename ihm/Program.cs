using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ihm.Vues;
using ihm.Controleur;

namespace ihm
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new Fenetre_gestion());

            ctrlPrincipal _cp = new ctrlPrincipal();

            while (_cp.encours == true)
                Application.DoEvents();
        }
    }
}
