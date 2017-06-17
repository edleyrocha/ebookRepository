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
#if DEBUG
                LogAppModeDebug.PrintOnDebug(@string_Print: string_Print, @numberSpace: numberSpace);
#else
                LogAppModeRelease.PrintOnRelease(@string_Print: string_Print, @numberSpace: numberSpace);
#endif
            }

        }

    }
}
