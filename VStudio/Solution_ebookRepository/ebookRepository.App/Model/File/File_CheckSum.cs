using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ebookRepository.App.Model.File
{
    class File_CheckSum
    {
        private int _FILE_DOC_COD;
        private string _CHECKSUM;

        public int FILE_DOC_COD
        {
            get
            {
                return _FILE_DOC_COD;
            }

            set
            {
                _FILE_DOC_COD = value;
            }
        }

        public string CHECKSUM
        {
            get
            {
                return _CHECKSUM;
            }

            set
            {
                _CHECKSUM = value;
            }
        }
    }
}