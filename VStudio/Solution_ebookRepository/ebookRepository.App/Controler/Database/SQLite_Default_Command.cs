#region ---> [USING]

using System;
using System.Data;
using System.Data.SQLite;

#endregion

#region ---> [NAMESPACE]

namespace ebookRepository.App.Controler.Database
{

    #region ---> [CLASS]

    class SQLite_Default_Command : IDisposable
    {

        #region ---> [CONSTRUTORS]

        public void Dispose()
        {
            GC.Collect();
        }
        ~SQLite_Default_Command()
        {
            this.Dispose();
        }

        #endregion

        #region ---> [METHODS]

        public SQLiteCommand GET_SQLite_Default_Command_CreateDatabase()
        {
            return (this.GET_SQLite_Command(@commandName: "DEFAULT_SQL_CREATE_DATABASE"));
        }

        public SQLiteCommand GET_SQLite_Default_Command_InsertFile()
        {
            return (this.GET_SQLite_Command(@commandName: "DEFAULT_SQL_INSERT_FILE_DOC"));
        }

        public SQLiteCommand GET_SQLite_Default_Command_InsertFileHash()
        {
            return (this.GET_SQLite_Command(@commandName: "DEFAULT_SQL_INSERT_FILE_DOC_HASH"));
        }

        public SQLiteCommand GET_SQLite_Default_Command_ReadFileHash()
        {
            return (this.GET_SQLite_Command(@commandName: "DEFAULT_SQL_READ_FILE_DOC_HASH"));
        }

        public SQLiteCommand GET_SQLite_Command(string commandName)
        {
            using (var _SQLite_Default_Connection = new SQLite_Default_Connection())
            {
                using (var _SQLite_Command = new SQLite_Command())
                {
                    var myReturn_SQLiteCommand = _SQLite_Command.GET_SQLite_Command(@commandName: commandName, @sqliteConnection: _SQLite_Default_Connection.GET_SQLite_Default_Connection());
                    return (myReturn_SQLiteCommand);
                }
            }
        }
        #endregion

    }

    #endregion

}

#endregion
