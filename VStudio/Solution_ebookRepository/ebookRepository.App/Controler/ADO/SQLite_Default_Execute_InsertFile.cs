
#region ---> [USING]

using System;
using System.IO;
using System.Data.SQLite;
using ebookRepository.App.Controler.Database;
using ebookRepository.App.Controler.Tools.Files;
using System.Collections.Generic;
using System.Data;

#endregion

#region ---> [NAMESPACE]

namespace ebookRepository.App.Controler.ADO
{

    #region ---> [CLASS]

    class SQLite_Default_Execute_InsertFile : IDisposable
    {

        #region ---> [CONSTRUTORS]

        public void Dispose()
        {
            GC.Collect();
        }
        ~SQLite_Default_Execute_InsertFile()
        {
            this.Dispose();
        }

        #endregion

        #region ---> [METHODS]

        public void Execute(List<object> ListObjects)
        {
            using (var _SQLite_Default_Database = new SQLite_Default_Database())
            {
                var SQLiteDB = _SQLite_Default_Database.GET_SQLite_Default_DatabaseFILE();
                if (File.Exists(SQLiteDB))
                {
                    using (var _SQLite_Default_Command = new SQLite_Default_Command())
                    {
                        var ResultROWID = this.Execute(_SQLite_Default_Command.GET_SQLite_Default_Command_InsertFile(), ListObjects);
                        if (ResultROWID >= 1)
                        {
                            ListObjects.Add(ResultROWID);
                            var ResultInsertHash = this.InsertHash(_SQLite_Default_Command.GET_SQLite_Default_Command_InsertFileHash(), ListObjects);

                            if(ResultInsertHash >= 1)
                            {
                                System.Windows.Forms.MessageBox.Show("Sucesso");
                            }
                            else
                            {
                                System.Windows.Forms.MessageBox.Show("Insert HASH Falhou");
                            }

                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("Insert File Falhou");
                        }

                    }
                }
            }
        }
        private long Execute(SQLiteCommand _SQLiteCommand, List<object> ListObjects)
        {
            long myReturn_Long = -5;
            try
            {
                _SQLiteCommand.Parameters.AddWithValue(("@F_NAME"), (string)(ListObjects[0]));
                _SQLiteCommand.Parameters.AddWithValue(("@F_EXTE"), (string)(ListObjects[1]));
                _SQLiteCommand.Parameters.AddWithValue(("@F_SIZE"), (string)(ListObjects[2]));
                _SQLiteCommand.Parameters.AddWithValue(("@F_BYTE"), (byte[])(ListObjects[3]));
                _SQLiteCommand.Parameters.AddWithValue(("@F_TIME"), (string)(ListObjects[4]));
                _SQLiteCommand.Connection.Open();
                using (var @BeginTransaction = _SQLiteCommand.Connection.BeginTransaction())
                {
                    _SQLiteCommand.ExecuteNonQuery();
                    @BeginTransaction.Commit();
                    myReturn_Long = _SQLiteCommand.Connection.LastInsertRowId;
                    _SQLiteCommand.Connection.Close();
                };

            }
            catch (Exception ex)
            {
                new ebookRepository.App.Controler.Tools.DebugApp.LogAppMode().PrintTheLog("SQLite_Default_Execute.Execute() ---> [ERRO]", 1);
                new ebookRepository.App.Controler.Tools.DebugApp.LogAppMode().PrintTheLog(ex.Message, 2);
            }
            return (myReturn_Long);
        }

        private long InsertHash(SQLiteCommand _SQLiteCommand, List<object> ListObjects)
        {
            long myReturn_Long = -5;
            try
            {
                _SQLiteCommand.Parameters.AddWithValue(("@ROWID"), (long)(ListObjects[8]));
                _SQLiteCommand.Parameters.AddWithValue(("@CHECKSUM_MD5"), (string)(ListObjects[5]));
                _SQLiteCommand.Parameters.AddWithValue(("@CHECKSUM_SHA1"), (string)(ListObjects[6]));
                _SQLiteCommand.Parameters.AddWithValue(("@CHECKSUM_SHA256"), (string)(ListObjects[7]));
                _SQLiteCommand.Connection.Open();
                using (var @BeginTransaction = _SQLiteCommand.Connection.BeginTransaction())
                {
                    myReturn_Long =  _SQLiteCommand.ExecuteNonQuery();
                    @BeginTransaction.Commit();
                    _SQLiteCommand.Connection.Close();
                };

            }
            catch (Exception ex)
            {
                new ebookRepository.App.Controler.Tools.DebugApp.LogAppMode().PrintTheLog("SQLite_Default_Execute.Execute() ---> [ERRO]", 1);
                new ebookRepository.App.Controler.Tools.DebugApp.LogAppMode().PrintTheLog(ex.Message, 2);
            }
            return (myReturn_Long);
        }
        #endregion

    }

    #endregion

}

#endregion