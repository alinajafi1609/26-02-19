using System;
using System.Windows.Forms;
namespace Electrical_Circuit_Simulator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (Menu Menu = new Menu())
            {
                Application.Run(Menu);
            }
        }
    }
}

