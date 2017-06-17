using ebookRepository.App.Controler.Tools.DebugApp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ebookRepository.App.Controler.Database
{
    class SQLite_Default_Database
    {

        public static string GET_SQLite_Default_DatabaseFILE()
        {
            LogAppMode.PrintTheLog();
            LogAppMode.PrintTheLog("GET_SQLite_Default_DatabaseFILE() [INICIO]");
            string myReturn_String = (String.Empty);
            try
            {
                string LocalDirApp = (System.AppDomain.CurrentDomain.BaseDirectory);
                string DefaultSQLiteDir = (Properties.Resources.ResourceManager.GetString("SQLiteDatabasePatch"));
                string FileNameSQLite = ((System.AppDomain.CurrentDomain.FriendlyName) + (".db3"));
                myReturn_String = (Path.Combine(LocalDirApp, DefaultSQLiteDir, FileNameSQLite));
                LogAppMode.PrintTheLog("GET_SQLite_Default_DatabaseFILE() [SUCESSO]", 1);
                LogAppMode.PrintTheLog(myReturn_String, 2);
            }
            catch (Exception ex)
            {
                LogAppMode.PrintTheLog("GET_SQLite_Default_DatabaseFILE() ---> [ERRO]", 1);
                LogAppMode.PrintTheLog(ex.Message, 2);
            }
            LogAppMode.PrintTheLog("GET_SQLite_Default_DatabaseFILE() [FIM]");
            return (myReturn_String);
        }

        public static string GET_SQLite_Default_DatabasePATCH()
        {
            LogAppMode.PrintTheLog();
            LogAppMode.PrintTheLog("GET_SQLite_Default_DatabasePATCH() [INICIO]");
            string myReturn_String = (String.Empty);
            try
            {
                string LocalDirApp = (System.AppDomain.CurrentDomain.BaseDirectory);
                string DefaultSQLiteDir = (Properties.Resources.ResourceManager.GetString("SQLiteDatabasePatch"));
                myReturn_String = (Path.Combine(LocalDirApp, DefaultSQLiteDir));
                LogAppMode.PrintTheLog("GET_SQLite_Default_DatabasePATCH() [SUCESSO]", 1);
                LogAppMode.PrintTheLog(myReturn_String, 2);
            }
            catch (Exception ex)
            {
                LogAppMode.PrintTheLog("GET_SQLite_Default_DatabasePATCH() ---> [ERRO]", 1);
                LogAppMode.PrintTheLog(ex.Message, 2);
            }
            LogAppMode.PrintTheLog("GET_SQLite_Default_DatabasePATCH() [FIM]");
            return (myReturn_String);
        }
    }
}
