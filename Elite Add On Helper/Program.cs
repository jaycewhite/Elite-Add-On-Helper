using System;
using System.Windows.Forms;

namespace Elite_Add_On_Helper
{

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //lets set up a settings folder in appdata

            Application.Run(new Form1());

        }
    }
}
