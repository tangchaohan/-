using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "ababaaaba";
            int[] next = new int[test.Length];
            int i = 1;
            int j = 0;
            next[1] = 0;
            while (i < test.Length- 1)
            {
                if (j == 0)
                { next[i] = j + 1; }
                if ( test[i] == test[j])
                {
                    i++; j++;
                    next[i] = j;
                }
                else
                { j = next[j ]; }
            }
            Console.ReadKey();
        }
    }
}
