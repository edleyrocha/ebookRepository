#region ---> [USING]

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

#endregion
namespace ebookRepository.App.Controler.Database
{
    #region ---> [Class]
    class SQLite_Command
    {

        private SQLiteCommand _SQLite_Command = new SQLiteCommand();
        public SQLite_Command()
        {
            this.ConfigureDefaultOptions();
        }
        private void ConfigureDefaultOptions()
        {
            _SQLite_Command.CommandTimeout = (5);
            _SQLite_Command.CommandType = (CommandType.Text);
        }

        public SQLiteCommand GET_SQLite_Command
        {
            get
            {
                return _SQLite_Command;
            }
        }
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


        public SQLiteCommand GET_SQLite_Command_Insert_File(SQLiteConnection SQLite_Connection)
        {
            var StringSQL = ("INSERT INTO [FILE_DOC]([NAME], [FILEBYTE], [FILEDATE]) VALUES (@NAME, @FILEBYTE,@FILEDATE);");
            _SQLite_Command.Connection = (SQLite_Connection);
            _SQLite_Command.CommandText = (StringSQL);
            return (_SQLite_Command);
        }
    }
    #endregion
}
