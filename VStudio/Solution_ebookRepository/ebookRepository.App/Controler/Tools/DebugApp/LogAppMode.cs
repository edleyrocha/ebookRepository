using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DebugAppMode;
namespace ebookRepository.App.Controler.Tools.DebugApp
{
    class LogAppMode
    {

        #region ---> [FILD]

        public static bool Enable_Print = (true);

        #endregion

        public static void PrintTheLog(string string_Print = "", int numberSpace = 0)
        {
            if (Enable_Print)
            {
                if (System.Diagnostics.Debugger.IsAttached)
                {
                    LogAppModeDebug.PrintOnDebug(@string_Print: string_Print, @numberSpace: numberSpace);
                }
                else if (!System.Diagnostics.Debugger.IsAttached)
                {

                }
            }

        }

    }
}
