#region ---> [USING]

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

#endregion

namespace ebookRepository.App.Controler.Database
{
    #region ---> [Class]
    class SQLite_Connection
    {
        #region ---> [Filds]
        private SQLiteConnection _SQLite_Connection = new SQLiteConnection();
        #endregion

        #region ---> [Construtor]
        public SQLite_Connection()
        {
        }
        #endregion

        #region ---> [Methods]
        public SQLiteConnection GET_SQLite_Connection(SQLite_ConnectionStringBuilder SQLite_ConnectionStringBuilder)
        {
            var StringBuilder = (SQLite_ConnectionStringBuilder.GET_SQLiteConnectionStringBuilder.ConnectionString);
            using (var SQLite_Conn = (new SQLiteConnection(StringBuilder)))
            {
                _SQLite_Connection = (SQLite_Conn);
            }
                return _SQLite_Connection;
        }
        #endregion
    }
    #endregion
}
