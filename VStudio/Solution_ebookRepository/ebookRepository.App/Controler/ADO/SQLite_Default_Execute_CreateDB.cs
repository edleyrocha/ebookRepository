
#region ---> [USING]

using System;
using System.IO;
using System.Data.SQLite;
using ebookRepository.App.Controler.Database;
using ebookRepository.App.Controler.Tools.Files;

#endregion

#region ---> [NAMESPACE]

namespace ebookRepository.App.Controler.ADO
{

    #region ---> [CLASS]

    class SQLite_Default_Execute_CreateDB : IDisposable
    {

        #region ---> [CONSTRUTORS]

        public void Dispose()
        {
            GC.Collect();
        }
        ~SQLite_Default_Execute_CreateDB()
        {
            this.Dispose();
        }

        #endregion

        #region ---> [METHODS]

        public void Execute()
        {
            using (var _SQLite_Default_Database = new SQLite_Default_Database())
            {
                var SQLiteDIR = (_SQLite_Default_Database.GET_SQLite_Default_DatabasePATCH());
                if (Directory.Exists(SQLiteDIR))
                {
                    var SQLiteDB = _SQLite_Default_Database.GET_SQLite_Default_DatabaseFILE();
                    if (!File.Exists(SQLiteDB))
                    {
                        using (var _SQLite_Default_Command = new SQLite_Default_Command())
                        {
                            this.Execute(_SQLite_Default_Command.GET_SQLite_Default_Command_CreateDatabase());
                        }
                    }
                }
                else
                {
                    new CreateDir().Create_SQLite_Default_DatabasePATCH();
                    this.Execute();
                };
            }
        }
        private void Execute(SQLiteCommand _SQLiteCommand)
        {
            try
            {
                using (_SQLiteCommand)
                {
                    _SQLiteCommand.Connection.Open();
                    using (var @BeginTransaction = _SQLiteCommand.Connection.BeginTransaction())
                    {
                        _SQLiteCommand.ExecuteNonQuery();
                        @BeginTransaction.Commit();
                        _SQLiteCommand.Connection.Close();
                    };
                };
            }
            catch (Exception ex)
            {
                new ebookRepository.App.Controler.Tools.DebugApp.LogAppMode().PrintTheLog("SQLite_Default_Execute.Execute() ---> [ERRO]", 1);
                new ebookRepository.App.Controler.Tools.DebugApp.LogAppMode().PrintTheLog(ex.Message, 2);
            }
        }

        #endregion

    }

    #endregion

}

#endregion