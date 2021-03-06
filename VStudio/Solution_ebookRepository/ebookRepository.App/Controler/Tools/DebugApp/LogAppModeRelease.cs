﻿#region ---> [USING]

using System;
using System.IO;
using System.Windows.Forms;
using ebookRepository.App.Controler.Tools.DebugApp;
using System.Collections.Generic;

#endregion

#region ---> [NAMESPACE]

namespace DebugAppMode
{
    #region ---> [CLASS]

    class LogAppModeRelease
    {

        #region ---> [METHODS]

        public void PrintOnRelease(string string_Print, int numberSpace)
        {
            List<object> ListObjects = new List<object>();
            ListObjects.Add(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            var dateTimeNowStrings = (String.Format(("{0}{1}{2}"), (".[LOG].["), (DateTime.Now.ToString("dd-MM-yyyy")),("].txt")));
            var FileNameFormated = (string.Format(("{0}{1}"), ((string)(ListObjects[0])),(dateTimeNowStrings)));
            ListObjects.Add(FileNameFormated);
            try
            {
                if (!string.IsNullOrEmpty(string_Print))
                {
                    for (int i = 0; i <= numberSpace; i++)
                    {
                        if (i >= 1)
                            string_Print = string_Print.Insert(0, " ");
                    }
                    using (StreamWriter writer = new StreamWriter(((string)(ListObjects[1])), true))
                    {

                        writer.WriteLine(String.Format(("{0} - [{1}]"), (string_Print), (DateTime.Now)));
                        writer.Close();
                    }
                }
                if (string.IsNullOrEmpty(string_Print))
                {
                    using (StreamWriter writer = new StreamWriter(((string)(ListObjects[1])), true))
                    {
                        writer.WriteLine(String.Format(("{0}"), ("\n")));
                        writer.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Favor Apagar [LOG] \n" + (ex.Message), "Erro Log", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

    }

    #endregion
}

#endregion