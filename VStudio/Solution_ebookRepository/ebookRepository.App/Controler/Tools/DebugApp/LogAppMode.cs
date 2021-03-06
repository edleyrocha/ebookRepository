﻿#region ---> [USING]

using System;
using DebugAppMode;

#endregion

#region ---> [NAMESPACE]

namespace ebookRepository.App.Controler.Tools.DebugApp
{

    #region ---> [CLASS]

    class LogAppMode
    {

        #region ---> [FILD]

        public static bool Enable_Print = (true);

        #endregion

        #region ---> [METHODS]
        public void PrintTheLog(string string_Print = "", int numberSpace = 0)
        {
            if (Enable_Print)
            {
#if DEBUG
                new LogAppModeDebug().PrintOnDebug(@string_Print: string_Print, @numberSpace: numberSpace);
#else
               new LogAppModeRelease().PrintOnRelease(@string_Print: string_Print, @numberSpace: numberSpace);
#endif
            }

        }

        #endregion

    }

    #endregion

}

#endregion