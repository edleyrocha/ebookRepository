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

        public SQLiteCommand GET_SQLite_Command(string commandName, CommandType commandType = (CommandType.Text))
        {
            using (var _SQLite_Default_Connection = new SQLite_Default_Connection())
            {
                var _SQLiteCommand = new SQLiteCommand();
                var StringSQL = (Properties.Resources.ResourceManager.GetString(commandName));
                _SQLiteCommand.Connection = (_SQLite_Default_Connection.GET_SQLite_Default_Connection());
                _SQLiteCommand.CommandTimeout = (5);
                _SQLiteCommand.CommandType = (commandType);
                _SQLiteCommand.CommandText = (StringSQL);
                return (_SQLiteCommand);
            }
        }
        #endregion
    }

    #endregion

}

#endregion