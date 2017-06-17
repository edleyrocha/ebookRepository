
#region ---> [USING]

using System;
using System.Data;
using System.Data.SQLite;
using System.Collections.Generic;

#endregion

#region ---> [NAMESPACE]

namespace ebookRepository.App.Controler.Database
{
    #region ---> [Class]
    class SQLite_Command
    {
        #region ---> [FILDS]

        private static SQLiteCommand _SQLite_Command = new SQLiteCommand();

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
            _SQLite_Command.Parameters.Clear();
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

        public static SQLiteCommand GET_SQLite_Command_Insert_File(List<object> ListObjects)
        {
            var StringSQL = ("INSERT INTO [FILE_DOC]([NAME], [EXTENSION], [FILEBYTE], [FILEDATE]) VALUES (@NAME, @EXTENSION,@FILEBYTE,@FILEDATE); ");
            StringSQL += ("INSERT INTO [FILE_CHECKSUM_MD5]([FILE_DOC_COD], [CHECKSUM_MD5]) VALUES ((SELECT MAX(COD) FROM [FILE_DOC]), @CHECKSUM_MD5); ");
            StringSQL += ("INSERT INTO [FILE_CHECKSUM_SHA1]([FILE_DOC_COD], [CHECKSUM_SHA1]) VALUES ((SELECT MAX(COD) FROM [FILE_DOC]), @CHECKSUM_SHA1); ");
            StringSQL += ("INSERT INTO[FILE_CHECKSUM_SHA256]([FILE_DOC_COD], [CHECKSUM_SHA256]) VALUES((SELECT MAX(COD) FROM[FILE_DOC]), @CHECKSUM_SHA256); ");

            _SQLite_Command.CommandText = (StringSQL);
            _SQLite_Command.Parameters.AddWithValue("@NAME", ((string)(ListObjects[0])));
            _SQLite_Command.Parameters.AddWithValue("@EXTENSION", ((string)(ListObjects[1])));
            _SQLite_Command.Parameters.AddWithValue("@FILEBYTE", ((byte[])(ListObjects[2])));
            _SQLite_Command.Parameters.AddWithValue("@FILEDATE", ((DateTime)(ListObjects[3])));
            _SQLite_Command.Parameters.AddWithValue("@CHECKSUM_MD5", ((byte[])(ListObjects[4])));
            _SQLite_Command.Parameters.AddWithValue("@CHECKSUM_SHA1", ((byte[])(ListObjects[5])));
            _SQLite_Command.Parameters.AddWithValue("@CHECKSUM_SHA256", ((byte[])(ListObjects[6])));
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