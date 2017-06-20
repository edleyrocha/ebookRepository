#region ---> [USING]

using System;

#endregion

#region ---> [NAMESPACE]

namespace ebookRepository.App.Controler.Tools.Encoder
{

    #region ---> [CLASS]

    class BytesString_EncoderDecoder : IDisposable
    {

        #region ---> [CONSTRUTORS]

        public void Dispose()
        {
            GC.Collect();
        }
        ~BytesString_EncoderDecoder()
        {
            this.Dispose();
        }

        #endregion

        #region ---> [METHODS]

        public static byte[] GetBytesFromString(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        public static string GetStringFromBytes(byte[] bytes)
        {
            char[] chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }

        #endregion

    }

    #endregion

}

#endregion
//https://stackoverflow.com/questions/16072709/converting-string-to-byte-array-in-c-sharp