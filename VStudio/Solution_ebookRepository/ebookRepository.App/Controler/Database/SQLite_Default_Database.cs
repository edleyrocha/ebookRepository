#region ---> [USING]

using System;
using System.IO;

#endregion

#region ---> [NAMESPACE]

namespace ebookRepository.App.Controler.Database
{

    #region ---> [CLASS]

    class SQLite_Default_Database : IDisposable
    {

        #region ---> [CONSTRUTORS]

        public void Dispose()
        {
            GC.Collect();
        }
        ~SQLite_Default_Database()
        {
            this.Dispose();
        }

        #endregion

        #region ---> [METHODS]

        public string GET_SQLite_Default_DatabaseFILE()
        {
            string myReturn_String = (String.Empty);
            try
            {
                string LocalDirApp = (System.AppDomain.CurrentDomain.BaseDirectory);
                string DefaultSQLiteDir = (Properties.Resources.ResourceManager.GetString("SQLiteDatabasePatch"));
                string FileNameSQLite = ((System.AppDomain.CurrentDomain.FriendlyName) + (".db3"));
                myReturn_String = (Path.Combine(LocalDirApp, DefaultSQLiteDir, FileNameSQLite));
            }
            catch (Exception ex)
            {
                ebookRepository.App.Controler.Tools.DebugApp.LogAppMode.PrintTheLog("GET_SQLite_Default_DatabaseFILE() ---> [ERRO]", 1);
                ebookRepository.App.Controler.Tools.DebugApp.LogAppMode.PrintTheLog(ex.Message, 2);
            }
            return (myReturn_String);
        }

        public string GET_SQLite_Default_DatabasePATCH()
        {
            string myReturn_String = (String.Empty);
            try
            {
                string LocalDirApp = (System.AppDomain.CurrentDomain.BaseDirectory);
                string DefaultSQLiteDir = (Properties.Resources.ResourceManager.GetString("SQLiteDatabasePatch"));
                myReturn_String = (Path.Combine(LocalDirApp, DefaultSQLiteDir));
            }
            catch (Exception ex)
            {
                ebookRepository.App.Controler.Tools.DebugApp.LogAppMode.PrintTheLog("GET_SQLite_Default_DatabasePATCH() ---> [ERRO]", 1);
                ebookRepository.App.Controler.Tools.DebugApp.LogAppMode.PrintTheLog(ex.Message, 2);
            }
            return (myReturn_String);
        }

        #endregion

    }

    #endregion
}

#endregion