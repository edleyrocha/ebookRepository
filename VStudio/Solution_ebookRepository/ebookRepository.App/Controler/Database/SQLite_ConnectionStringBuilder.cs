#region ---> [USING]

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

#endregion

namespace ebookRepository.App.Controler.Database
{
    #region ---> [Class]
    class SQLite_ConnectionStringBuilder
    {
        #region ---> [Filds]
        private SQLiteConnectionStringBuilder _SQLite_ConnectionStringBuilder = new SQLiteConnectionStringBuilder();
        #endregion

        #region ---> [Construtor]

        SQLite_ConnectionStringBuilder()
        {
            this.ConfigureDefaultOptions();
        }

        #endregion

        #region ---> [Methods]

        private void ConfigureDefaultOptions()
        {
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

        public void SET_Passwd(byte[] Password_byteArray = null   , string Password_String = null)
        {
            if (!(Password_byteArray.Equals(null)))
            {
                _SQLite_ConnectionStringBuilder.HexPassword = (Password_byteArray);
            }
            else if (!(Password_String.Equals(null)))
            {
                _SQLite_ConnectionStringBuilder.Password = (Password_String);
            };
        }

        public bool SET_FailIfMissing
        {
            set { _SQLite_ConnectionStringBuilder.FailIfMissing = value; }
        }

        public bool SET_ReadOnly
        {
            set { _SQLite_ConnectionStringBuilder.ReadOnly = value; }
        }

        #endregion
    }
    #endregion
}
