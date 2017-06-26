
#region ---> [USING]

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using ebookRepository.App.Controler.Database;
using System.IO;
using System.Windows.Forms;

#endregion

#region ---> [NAMESPACE]

namespace ebookRepository.App.Controler.ADO
{

    #region ---> [CLASS]

    class SQLite_Default_Execute_GetDatasetFiles : IDisposable
    {

        #region ---> [CONSTRUTORS]

        public void Dispose()
        {
            GC.Collect();
        }
        ~SQLite_Default_Execute_GetDatasetFiles()
        {
            this.Dispose();
        }

        #endregion

        #region ---> [METHODS]
        public DataTable Execute()
        {
            var _SQLite_Default_Command = new SQLite_Default_Command().GET_SQLite_Default_Command_ReadFileHash();
            var myReturn_DataSet = new DataTable();
            myReturn_DataSet = this.Execute(@_SQLiteCommand: _SQLite_Default_Command);
            return (myReturn_DataSet);
        }

        private DataTable Execute(SQLiteCommand _SQLiteCommand)
        {
            var myReturn_DataSet = new DataTable();
            _SQLiteCommand.Connection.Open();
            _SQLiteCommand.CommandText = _SQLiteCommand.CommandText.Replace(("@NAME"), (string.Empty));
            var _SQLiteDataAdapter = (new SQLiteDataAdapter(_SQLiteCommand));
            _SQLiteDataAdapter.Fill(myReturn_DataSet);
            _SQLiteCommand.Connection.Close();
            return (myReturn_DataSet);
        }

        public SQLiteDataReader Execute(string stringFind)
        {
            using (var _SQLite_Default_Command = new SQLite_Default_Command().GET_SQLite_Default_Command_ReadFileHash())
            {
                var _SQLiteDataReader = this.Execute(@_SQLiteCommand: _SQLite_Default_Command, @stringFind: stringFind);
                return (_SQLiteDataReader);
            }
        }

        private SQLiteDataReader Execute(SQLiteCommand _SQLiteCommand, string stringFind)
        {
            _SQLiteCommand.CommandText = _SQLiteCommand.CommandText.Replace(("@NAME"), (stringFind));
            _SQLiteCommand.Connection.Open();
            var _SQLiteDataReader = _SQLiteCommand.ExecuteReader();
            return (_SQLiteDataReader);
        }


        #endregion

    }

    #endregion

}

#endregion