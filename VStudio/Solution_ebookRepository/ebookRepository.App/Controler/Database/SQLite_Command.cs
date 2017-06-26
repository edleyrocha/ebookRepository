#region ---> [USING]

using System;
using System.Data;
using System.Data.SQLite;

#endregion

#region ---> [NAMESPACE]

namespace ebookRepository.App.Controler.Database
{

    #region ---> [CLASS]

    class SQLite_Command : IDisposable
    {

        #region ---> [CONSTRUTORS]

        public void Dispose()
        {
            GC.Collect();
        }
        ~SQLite_Command()
        {
            this.Dispose();
        }

        #endregion

        #region ---> [METHODS]

        public SQLiteCommand GET_SQLite_Command(string commandName, SQLiteConnection sqliteConnection = null, CommandType commandType = (CommandType.Text))
        {
            var StringSQL = (Properties.Resources.ResourceManager.GetString(commandName));
            var _SQLiteCommand = new SQLiteCommand();
            _SQLiteCommand.Connection = (sqliteConnection);
            _SQLiteCommand.CommandTimeout = (5);
            _SQLiteCommand.CommandType = (commandType);
            _SQLiteCommand.CommandText = (StringSQL);
            return (_SQLiteCommand);
        }
        #endregion
    }

    #endregion

}

#endregion