#region ---> [USING]

using System;
using System.IO;
using ebookRepository.App.Controler.Tools.DebugApp;
using ebookRepository.App.Controler.Database;

#endregion

namespace ebookRepository.App.Controler.Tools.Files
{

    #region ---> [CLASS]

    class CreateDir
    {

        #region ---> [METHODS]

        private static bool CreateNewDir(string newDir)
        {
            LogAppMode.PrintTheLog();
            LogAppMode.PrintTheLog("CreateNewDir() [INICIO]");
            var myReturn_bool = (false);
            try
            {
                if (!Directory.Exists(newDir))
                {
                    Directory.CreateDirectory(newDir);
                    myReturn_bool = (true);
                    LogAppMode.PrintTheLog("CreateNewDir() ---> " + "[" + myReturn_bool + "] [SUCESSO]", 1);
                    LogAppMode.PrintTheLog((newDir), 2);
                }
                else
                {
                    throw new ArgumentException(("[JA EXISTE] [" + (newDir) + "]"), "CreateNewDir()");
                }
            }
            catch (Exception ex)
            {
                LogAppMode.PrintTheLog("CreateNewDir() ---> " + "[" + myReturn_bool + "] [ERRO]", 1);
                LogAppMode.PrintTheLog(ex.Message, 2);
            }
            LogAppMode.PrintTheLog("CreateNewDir() [FIM]");
            return (myReturn_bool);
        }
        public static bool CreateSQLiteLocalDatabaseStore()
        {
            LogAppMode.PrintTheLog();
            LogAppMode.PrintTheLog("CreateSQLiteLocalDatabaseStore() [INICIO]");
            var myReturn_bool = (false);

            string DefaultSQLiteDir = (SQLite_Default_Database.GET_SQLite_Default_DatabasePATCH());
            myReturn_bool = (CreateNewDir(DefaultSQLiteDir));

            LogAppMode.PrintTheLog("CreateNewDir() ---> " + "[" + myReturn_bool + "] [SUCESSO]", 1);

            return (myReturn_bool);
        }

        #endregion
    }

    #endregion

}
