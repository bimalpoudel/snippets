using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snippets.snippets
{
    public class numbers
    {
        Random rand = new Random();

        //public const string literals = "abcdefghijklmnopqrstuvwyxzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        //public const string literals = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public const string literals = "0123456789";

        public string GenerateString(int size)
        {
            char[] chars = new char[size];
            for (int i = 0; i < size; ++i)
            {
                chars[i] = literals[rand.Next(literals.Length)];
            }

            return new string(chars);
        }
    }
}