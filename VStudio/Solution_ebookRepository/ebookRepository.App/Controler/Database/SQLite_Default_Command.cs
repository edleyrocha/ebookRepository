using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ebookRepository.App.Controler.Database
{
    class SQLite_Default_Command
    {
        public static SQLiteCommand GET_SQLite_Default_Command()
        {
            var _SQLiteCommand = new SQLiteCommand();
            var StringSQL = (Properties.Resources.ResourceManager.GetString("SQL_CREATE_DATABASE_DEFAULT"));
            _SQLiteCommand.CommandTimeout = (5);
            _SQLiteCommand.CommandType = (CommandType.Text);
            _SQLiteCommand.CommandText = (StringSQL);
            _SQLiteCommand.Connection = (SQLite_Default_Connection.GET_SQLite_Default_Connection());
            return (_SQLiteCommand);
        }
    }
}
