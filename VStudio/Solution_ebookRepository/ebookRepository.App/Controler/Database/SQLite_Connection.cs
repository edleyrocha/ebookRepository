
#region ---> [USING]

using System;
using System.Data.SQLite;

#endregion

#region ---> [NAMESPACE]

namespace ebookRepository.App.Controler.Database
{

    #region ---> [CLASS]

    class SQLite_Connection : IDisposable
    {

        #region ---> [CONSTRUTORS]

        public void Dispose()
        {
            GC.Collect();
        }
        ~SQLite_Connection()
        {
            this.Dispose();
        }

        #endregion

        #region ---> [METHODS]

        public SQLiteConnection GET_SQLite_Connection(SQLite_ConnectionStringBuilder SQLite_Connection_StringBuilder)
        {
            return (new SQLiteConnection(SQLite_Connection_StringBuilder.GET_SQLiteConnectionStringBuilder.ConnectionString));
        }

        #endregion
    }

    #endregion
}

#endregion