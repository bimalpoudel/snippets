// Copyright (c) 2011 rubicon IT GmbH
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * @see https://www.tutorialspoint.com/csharp/csharp_anonymous_methods.htm
 */
namespace snippets.snippets
{
    public delegate void NumberChanger(int n);

    public class delegator
    {
        static int num = 10;

        public void AddNum(int p)
        {
            int old = num;
            num += p;
            Console.WriteLine("Delegator: Named AddNum Method: {0} + {1} = {2}", old, p, num);
        }

        public void MultNum(int q)
        {
            int old = num;
            num *= q;
            Console.WriteLine("Delegator: Named MultNum Method: {0} x {1} = {2}", old, q, num);
        }

        public int getNum()
        {
            return num;
        }
    }
}
