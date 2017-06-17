
#region ---> [USING]

using System;
using System.Data.SQLite;

#endregion

#region ---> [NAMESPACE]

namespace ebookRepository.App.Controler.Database
{

    #region ---> [CLASS]

    class SQLite_Connection
    {
        #region ---> [METHODS]

        public static SQLiteConnection GET_SQLite_Connection(SQLite_ConnectionStringBuilder SQLite_Default_DatabasePatch)
        {
            var _SQLiteConnection = new SQLiteConnection();
            _SQLiteConnection.ConnectionString = (SQLite_Default_DatabasePatch.GET_SQLiteConnectionStringBuilder.ConnectionString);
            return (_SQLiteConnection);
        }

        #endregion
    }

    #endregion
}

#endregion