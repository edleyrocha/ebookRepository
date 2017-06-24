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
                string DefaultAppPatch = (System.AppDomain.CurrentDomain.BaseDirectory);
                string DefaultSQLitePatch = (this.GET_SQLite_Default_DatabasePATCH());
                string DefaultFileNameSQLite = ((System.AppDomain.CurrentDomain.FriendlyName) + (".db3"));
                myReturn_String = (Path.Combine(DefaultAppPatch, DefaultSQLitePatch, DefaultFileNameSQLite));
            }
            catch (Exception ex)
            {
                new ebookRepository.App.Controler.Tools.DebugApp.LogAppMode().PrintTheLog("GET_SQLite_Default_DatabaseFILE() ---> [ERRO]", 1);
                new ebookRepository.App.Controler.Tools.DebugApp.LogAppMode().PrintTheLog(ex.Message, 2);
            }
            return (myReturn_String);
        }

        public string GET_SQLite_Default_DatabasePATCH()
        {
            string myReturn_String = (String.Empty);
            try
            {
                string DefaultAppPatch = (System.AppDomain.CurrentDomain.BaseDirectory);
                string DefaultSQLitePatch = (Properties.Resources.ResourceManager.GetString("SQLiteDatabasePatch"));
                myReturn_String = (Path.Combine(DefaultAppPatch, DefaultSQLitePatch));
            }
            catch (Exception ex)
            {
                new ebookRepository.App.Controler.Tools.DebugApp.LogAppMode().PrintTheLog("GET_SQLite_Default_DatabasePATCH() ---> [ERRO]", 1);
                new ebookRepository.App.Controler.Tools.DebugApp.LogAppMode().PrintTheLog(ex.Message, 2);
            }
            return (myReturn_String);
        }

        #endregion

    }

    #endregion
}

#endregion