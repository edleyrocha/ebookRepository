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
            return (new SQLite_Command().GET_SQLite_Command(@commandName:"DEFAULT_SQL_CREATE_DATABASE"));
        }

        public SQLiteCommand GET_SQLite_Default_Command_InsertFile()
        {
            return (new SQLite_Command().GET_SQLite_Command(@commandName: "DEFAULT_SQL_INSERT_FILE_DOC"));
        }

        public SQLiteCommand GET_SQLite_Default_Command_InsertFileHash()
        {
            return (new SQLite_Command().GET_SQLite_Command(@commandName: "DEFAULT_SQL_INSERT_FILE_DOC_HASH"));
        }
        #endregion

    }

    #endregion

}

#endregion
