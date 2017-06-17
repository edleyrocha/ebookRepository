using ebookRepository.App.Controler.Database;
using ebookRepository.App.Controler.Tools.DebugApp;
using ebookRepository.App.Controler.Tools.Files;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ebookRepository.App.Controler.ADO
{
    class SQLite_Default_Execute
    {

        public static void Execute()
        {
            var SQLiteDB = SQLite_Default_Database.GET_SQLite_Default_DatabaseFILE();

            if (!File.Exists(SQLiteDB))
            {
                CreateDir.CreateSQLiteLocalDatabaseStore();
                SQLite_Default_Execute.Execute(@SQLite_Command: SQLite_Default_Command.GET_SQLite_Default_Command());
            }
        }
        private static void Execute(SQLiteCommand SQLite_Command)
        {
            LogAppMode.PrintTheLog();
            LogAppMode.PrintTheLog("SQLite_Default_Execute.Execute() [INICIO]");
            try
            {
                using (SQLite_Command)
                {
                    SQLite_Command.Connection.Open();
                    SQLite_Command.ExecuteNonQuery();
                    var COD = SQLite_Command.Connection.LastInsertRowId;
                    SQLite_Command.Connection.Clone();
                   
                    LogAppMode.PrintTheLog("SQLite_Default_Execute.Execute() ---> [SUCESSO]", 1);
                    LogAppMode.PrintTheLog(SQLite_Command.CommandText.ToString(), 2);
                    LogAppMode.PrintTheLog("SQLite_Default_Execute.Execute() ---> [COD] ---> : " + (COD.ToString()), 1);
                }
            }
            catch (Exception ex)
            {
                LogAppMode.PrintTheLog("SQLite_Default_Execute.Execute() ---> [ERRO]", 1);
                LogAppMode.PrintTheLog(ex.Message, 2);
            }
            LogAppMode.PrintTheLog("SQLite_Default_Execute.Execute() [FIM]");
        }
    }
}
