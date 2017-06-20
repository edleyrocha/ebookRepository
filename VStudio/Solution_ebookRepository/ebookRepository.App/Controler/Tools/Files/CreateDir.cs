#region ---> [USING]

using System;
using System.IO;
using ebookRepository.App.Controler.Database;

#endregion

#region ---> [NAMESPACE]

namespace ebookRepository.App.Controler.Tools.Files
{

    #region ---> [CLASS]

    class CreateDir : IDisposable
    {

        #region ---> [CONSTRUTORS]

        public void Dispose()
        {
            GC.Collect();
        }
        ~CreateDir()
        {
            this.Dispose();
        }

        #endregion

        #region ---> [METHODS]

        private bool CreateNewDir(string newDir)
        {
            var myReturn_bool = (false);
            try
            {
                if (!Directory.Exists(newDir))
                {
                    Directory.CreateDirectory(newDir);
                    myReturn_bool = (true);
                }
                else
                {
                    throw new ArgumentException(("[JA EXISTE] [" + (newDir) + "]"), "CreateNewDir()");
                }
            }
            catch (Exception ex)
            {
                new ebookRepository.App.Controler.Tools.DebugApp.LogAppMode().PrintTheLog("CreateNewDir() ---> " + "[" + myReturn_bool + "] [ERRO]", 1);
                new ebookRepository.App.Controler.Tools.DebugApp.LogAppMode().PrintTheLog(ex.Message, 2);
            }
            return (myReturn_bool);
        }

        public bool Create_SQLite_Default_DatabasePATCH()
        {
            var myReturn_bool = (false);
            string DefaultSQLiteDir = (new SQLite_Default_Database().GET_SQLite_Default_DatabasePATCH());
            myReturn_bool = (CreateNewDir(DefaultSQLiteDir));
            return (myReturn_bool);
        }

        #endregion

    }

    #endregion

}

#endregion