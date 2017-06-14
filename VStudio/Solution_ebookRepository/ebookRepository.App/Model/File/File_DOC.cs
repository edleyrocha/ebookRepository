using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ebookRepository.App.Model.File
{
    class File_DOC
    {
        private int _COD;
        private string _NAME;
        private byte[] _FILEBYTE;
        private DateTime _FILEDATE;
        public int COD
        {
            get
            {
                return _COD;
            }

            set
            {
                _COD = value;
            }
        }

        public string NAME
        {
            get
            {
                return _NAME;
            }

            set
            {
                _NAME = value;
            }
        }

        public byte[] FILEBYTE
        {
            get
            {
                return _FILEBYTE;
            }

            set
            {
                _FILEBYTE = value;
            }
        }

        public DateTime FILEDATE
        {
            get
            {
                return _FILEDATE;
            }

            set
            {
                _FILEDATE = value;
            }
        }
    }
}