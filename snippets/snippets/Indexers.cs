using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * @see https://www.tutorialspoint.com/csharp/csharp_indexers.htm
 */
namespace snippets.snippets
{
    class Indexers
    {
        public static int size = 5;
        private string[] namelist = new string[size];

        public Indexers(int _size = 5)
        {
            //this.size = _size;
            for (int i = 0; i < size; i++)
            {
                namelist[i] = "N. A.";
            }
        }

        public string this[int index]
        {
            get
            {
                string tmp;

                if (index >= 0 && index <= size - 1)
                {
                    tmp = namelist[index];
                }
                else
                {
                    tmp = "";
                }

                return tmp;
            }
            set
            {
                if (index >= 0 && index <= size - 1)
                {
                    namelist[index] = value;
                }
            }
        }
    }
}
