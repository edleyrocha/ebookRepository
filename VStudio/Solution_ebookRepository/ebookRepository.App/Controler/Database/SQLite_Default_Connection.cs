#region ---> [USING]

using System;
using System.Data.SQLite;
using ebookRepository.App.Controler.Tools.Encoder;

#endregion

#region ---> [NAMESPACE]

namespace ebookRepository.App.Controler.Database
{
    #region ---> [CLASS]
    class SQLite_Default_Connection : IDisposable
    {

        #region ---> [CONSTRUTORS]

        public void Dispose()
        {
            GC.Collect();
        }
        ~SQLite_Default_Connection()
        {
            this.Dispose();
        }

        #endregion

        #region ---> [METHODS]

        public SQLiteConnection GET_SQLite_Default_Connection()
        {
            using (var _SQLite_ConnectionStringBuilder = new SQLite_ConnectionStringBuilder()
            {
                SET_FailIfMissing = (false),
                SET_Password = ("123456"),
                //SET_Password = (new BytesEncoder().DecodeToBytes("123456")),
                SET_DataSource = (new SQLite_Default_Database().GET_SQLite_Default_DatabaseFILE())
            })
            {
                return (new SQLite_Connection().GET_SQLite_Connection(_SQLite_ConnectionStringBuilder));
            };
        }

        #endregion

    }

    #endregion

}

#endregion