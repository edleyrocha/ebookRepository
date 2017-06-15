using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ebookRepository.App.Controler.Tools.DebugApp;

namespace ebookRepository.App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            LogAppMode.PrintTheLog();
            LogAppMode.PrintTheLog("App [INICIO]");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Application.Run(new ebookRepository.App.View.form_InsertFiles());
            LogAppMode.PrintTheLog("App [FIM]");
        }
    }
}
