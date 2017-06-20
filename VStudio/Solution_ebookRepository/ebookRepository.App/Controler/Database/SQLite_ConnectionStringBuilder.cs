
#region ---> [USING]

using System;
using System.Data.SQLite;

#endregion

#region ---> [NAMESPACE]

namespace ebookRepository.App.Controler.Database
{

    #region ---> [CLASS]

    class SQLite_ConnectionStringBuilder : IDisposable
    {
        #region ---> [FILDS]

        private SQLiteConnectionStringBuilder _SQLite_ConnectionStringBuilder;

        #endregion

        #region ---> [CONSTRUTORS]

        public SQLite_ConnectionStringBuilder()
        {
            this.ConfigureDefaultOptions();
        }
        
        public void Dispose()
        {
            _SQLite_ConnectionStringBuilder = (null);
            GC.Collect();
        }
        ~SQLite_ConnectionStringBuilder()
        {
            this.Dispose();
        }

        #endregion

        #region ---> [METHODS]

        private void ConfigureDefaultOptions()
        {
            _SQLite_ConnectionStringBuilder = new SQLiteConnectionStringBuilder();
            _SQLite_ConnectionStringBuilder.Clear();
            _SQLite_ConnectionStringBuilder.SetDefaults = (true);
            _SQLite_ConnectionStringBuilder.FailIfMissing = (true); // Segurança por Padrao Nao Pemite Criar novo DB
            _SQLite_ConnectionStringBuilder.ForeignKeys = (true);
            _SQLite_ConnectionStringBuilder.DefaultTimeout = (5000);
            _SQLite_ConnectionStringBuilder.PageSize = (65536);
            _SQLite_ConnectionStringBuilder.CacheSize = (2048000);
            _SQLite_ConnectionStringBuilder.SyncMode = (SynchronizationModes.Full);
            _SQLite_ConnectionStringBuilder.JournalMode = (SQLiteJournalModeEnum.Memory);
            _SQLite_ConnectionStringBuilder.Flags = (SQLiteConnectionFlags.LogAll);
        }
        
        #endregion

        #region ---> [GET]

        public SQLiteConnectionStringBuilder GET_SQLiteConnectionStringBuilder
        {
            get { return _SQLite_ConnectionStringBuilder; }
        }

        #endregion

        #region ---> [SET]

        public string SET_DataSource
        {
            set { _SQLite_ConnectionStringBuilder.DataSource = value; }
        }
        public bool SET_FailIfMissing
        {
            set { _SQLite_ConnectionStringBuilder.FailIfMissing = value; }
        }
        public bool SET_ReadOnly
        {
            set { _SQLite_ConnectionStringBuilder.ReadOnly = value; }
        }
        public object SET_Password
        {
            set
            {
                object myValueObject = (value);
                if (myValueObject is string)
                {
                    string myValueString = ((string)(myValueObject));
                    _SQLite_ConnectionStringBuilder.Password = (myValueString);

                }
                else if (myValueObject is byte[])
                {
                    byte[] myValueByteArray = ((byte[])(myValueObject));
                    _SQLite_ConnectionStringBuilder.HexPassword = (myValueByteArray);
                }
            }
        }

        #endregion

    }

    #endregion

}

#endregion