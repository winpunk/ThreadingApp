using System;
using System.Windows.Forms;

namespace ThreadingApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var dbManager = new DbManager();
            var randomLineGenerator = new RandomLineGenerator();
            Application.Run(new ThreadingApp(dbManager, randomLineGenerator));
        }
    }
}