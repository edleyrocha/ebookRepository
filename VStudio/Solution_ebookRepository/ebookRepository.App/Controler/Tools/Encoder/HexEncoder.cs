#region ---> [USING]

using System;

#endregion

#region ---> [NAMESPACE]

namespace ebookRepository.App.Controler.Tools.Encoder
{

    #region ---> [CLASS]

    class HexEncoder : IDisposable
    {

        #region ---> [CONSTRUTORS]

        public void Dispose()
        {
            GC.Collect();
        }
        ~HexEncoder()
        {
            this.Dispose();
        }

        #endregion

        #region ---> [METHODS]
        public string ByteArray_to_HexArray(byte[] bytes)
        {
            return (BitConverter.ToString(bytes).Replace("-", string.Empty));
        }
        public byte[] HexArry_to_ByteArray(String hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }

        #endregion

    }

    #endregion

}

#endregion