using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ebookRepository.App.Controler.Database
{
    class SQLite_Default_Connection
    {
        public static SQLiteConnection GET_SQLite_Default_Connection()
        {
            var mySQLite_ConnectionStringBuilder = new SQLite_ConnectionStringBuilder()
            {
                SET_FailIfMissing = (false),
                SET_Password = ("123456"),
                SET_DataSource = (SQLite_Default_Database.GET_SQLite_Default_DatabaseFILE())
            };
            //var _SQLiteConnection = new SQLiteConnection();
            //_SQLiteConnection.ConnectionString = (mySQLite_ConnectionStringBuilder.GET_SQLiteConnectionStringBuilder.ConnectionString);
            return (SQLite_Connection.GET_SQLite_Connection(mySQLite_ConnectionStringBuilder));
        }
    }
}
