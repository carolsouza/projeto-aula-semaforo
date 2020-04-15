using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Semaforo.Views;

namespace Semaforo
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login());
            Login logar = new Login();
            if(logar.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Home());
            }


        }
    }
}
