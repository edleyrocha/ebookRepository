#region ---> [USING]

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

#endregion

#region ---> [NAMESPACE]

namespace ebookRepository.App.Controler.Database
{
    #region ---> [Class]
    class SQLite_Command
    {
        #region ---> [FILDS]

        private SQLiteCommand _SQLite_Command = new SQLiteCommand();

        #endregion

        #region ---> [CONSTRUCTOR]

        public SQLite_Command()
        {
            this.ConfigureDefaultOptions();
        }

        #endregion

        #region ---> [METHODS]

        private void ConfigureDefaultOptions()
        {
            _SQLite_Command.CommandTimeout = (5);
            _SQLite_Command.CommandType = (CommandType.Text);
        }

        #endregion

        #region ---> [GET]
        public SQLiteCommand GET_SQLite_Command
        {
            get
            {
                return _SQLite_Command;
            }
        }

        public SQLiteCommand GET_SQLite_Command_Insert_File()
        {
            var StringSQL = ("INSERT INTO [FILE_DOC]([NAME], [FILEBYTE], [FILEDATE]) VALUES (@NAME, @FILEBYTE,@FILEDATE);");
            _SQLite_Command.CommandText = (StringSQL);
            return (_SQLite_Command);
        }
        #endregion

        #region ---> [SET]
        public int SET_SQLite_Command_CommandTimeout
        {
            set
            {
                _SQLite_Command.CommandTimeout = value;
            }
        }
        public CommandType SET_SQLite_Command_CommandType
        {
            set
            {
                _SQLite_Command.CommandType = value;
            }
        }

        #endregion

    }

    #endregion
}

#endregion