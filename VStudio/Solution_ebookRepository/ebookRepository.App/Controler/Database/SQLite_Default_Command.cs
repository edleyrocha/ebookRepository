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

        public SQLiteCommand GET_SQLite_Default_Command()
        {
            using (var _SQLite_Default_Connection = new SQLite_Default_Connection())
            {
                var StringSQL = (Properties.Resources.ResourceManager.GetString("SQL_CREATE_DATABASE_DEFAULT"));
                var _SQLiteCommand = new SQLiteCommand();
                _SQLiteCommand.Connection = (_SQLite_Default_Connection.GET_SQLite_Default_Connection());
                _SQLiteCommand.CommandTimeout = (5);
                _SQLiteCommand.CommandType = (CommandType.Text);
                _SQLiteCommand.CommandText = (StringSQL);
                return (_SQLiteCommand);
            }
        }

        #endregion

    }

    #endregion

}

#endregion
