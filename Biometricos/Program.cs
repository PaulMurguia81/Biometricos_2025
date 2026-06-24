using Biometricos.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biometricos
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool nuevaInstancia;
            using (System.Threading.Mutex mutex = new System.Threading.Mutex(true, System.Diagnostics.Process.GetCurrentProcess().ProcessName, out nuevaInstancia))
            {
                if (nuevaInstancia)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    //Application.Run(new Form1());
                    Application.Run(new Login());
                }
                else
                    MessageBox.Show("La aplicacion esta ejecutándose");
            }
        }
    }
}
