#region ---> [USING]

using System;

#endregion

#region ---> [NAMESPACE]

namespace DebugAppMode
{

    #region ---> [CLASS]

    class LogAppModeDebug
    {

        #region ---> [METHODS]

        public static void PrintOnDebug(string string_Print, int numberSpace)
        {
            if (!string.IsNullOrEmpty(string_Print))
            {
                for (int i = 0; i <= numberSpace; i++)
                {
                    if (i >= 1)
                        string_Print = string_Print.Insert(0, " ");
                }

                System.Diagnostics.Debug.WriteLine(String.Format(("{0} - [{1}]"), (string_Print), (DateTime.Now)));
            }
            if (string.IsNullOrEmpty(string_Print))
            {
                System.Diagnostics.Debug.WriteLine(String.Format(("{0}"), ("\n")));
            }
        }

        #endregion

    }

    #endregion

}

#endregion
//else if (!System.Diagnostics.Debugger.IsAttached)
//{
//    if (EnablePrintDebug)
//    {
//        System.Diagnostics.Trace.WriteLine("xxxxxxx1");
//        System.Diagnostics.Debug.WriteLine("xxxxxxxxx2");
//    }
//}

/*

    [System.Diagnostics.Conditional("DEBUG")]

    #if (DEBUG)
    System.Diagnostics.Trace.WriteLine(String_Print);
    #endif

    if (System.Diagnostics.Debugger.IsAttached)

*/
