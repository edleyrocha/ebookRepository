using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ebookRepository.App.Controler.ADO;

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
            new ebookRepository.App.Controler.Tools.DebugApp.LogAppMode().PrintTheLog();
            new ebookRepository.App.Controler.Tools.DebugApp.LogAppMode().PrintTheLog("App [INICIO]");
            new SQLite_Default_Execute().Execute();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Application.Run(new ebookRepository.App.View.form_InsertFiles());
            new ebookRepository.App.Controler.Tools.DebugApp.LogAppMode().PrintTheLog();
            new ebookRepository.App.Controler.Tools.DebugApp.LogAppMode().PrintTheLog("App [FIM]");
        }
    }
}
