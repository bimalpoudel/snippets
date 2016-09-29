using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace snippets.snippets
{
    public class hasher
    {
        private string treat(string value)
        {
            return value.ToUpper();
        }
        public string sha1(string buffer)
        {
            System.Security.Cryptography.SHA1CryptoServiceProvider cryptoProvider = new System.Security.Cryptography.SHA1CryptoServiceProvider();

            string hash = BitConverter.ToString(cryptoProvider.ComputeHash(Encoding.ASCII.GetBytes(buffer)));

            // @see http://stackoverflow.com/questions/651702/string-replacechar-char-method-in-c-sharp
            hash = hash.Replace("-", "");
            //hash = hash.Replace('-', '\0');

            return this.treat(hash);
        }

        /**
         * @see https://blogs.msdn.microsoft.com/csharpfaq/2006/10/09/how-do-i-calculate-a-md5-hash-from-a-string/
         */
        public string md5(string buffer)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(buffer);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; ++i)
            {
                sb.Append(hash[i].ToString("X2"));
            }

            return this.treat(sb.ToString());
        }
    }
}
