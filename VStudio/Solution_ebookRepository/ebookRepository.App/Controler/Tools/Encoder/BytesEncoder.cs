#region ---> [USING]

using System;

#endregion

#region ---> [NAMESPACE]

namespace ebookRepository.App.Controler.Tools.Encoder
{

    #region ---> [CLASS]

    class BytesEncoder : IDisposable
    {

        #region ---> [CONSTRUTORS]

        public void Dispose()
        {
            GC.Collect();
        }
        ~BytesEncoder()
        {
            this.Dispose();
        }

        #endregion

        #region ---> [METHODS]
        public string EncodeToString(byte[] bytes)
        {
            bool even = (bytes.Length % 2 == 0);
            char[] chars = new char[1 + bytes.Length / sizeof(char) + (even ? 0 : 1)];
            chars[0] = (even ? '0' : '1');
            System.Buffer.BlockCopy(bytes, 0, chars, 2, bytes.Length);
            return new string(chars);
        }
        public byte[] DecodeToBytes(string str)
        {
            bool even = str[0] == '0';
            byte[] bytes = new byte[(str.Length - 1) * sizeof(char) + (even ? 0 : -1)];
            char[] chars = str.ToCharArray();
            System.Buffer.BlockCopy(chars, 2, bytes, 0, bytes.Length);
            return bytes;
        }

        #endregion

    }

    #endregion

}

#endregion
//https://stackoverflow.com/questions/16072709/converting-string-to-byte-array-in-c-sharp