using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int edno = 1;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{0}", new string('*', i+1),
                    new string('\u005c', edno), new string('-', (2*n-1) -2*i), new string('/', edno), new string('*', i));
            }

            for (int i = 0; i < n/3; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{4}{1}{0}", new string('|', edno), new string('*', n/2 + i),
                    new string('\u005c', edno), new string('*', n-2*i), new string('/', edno));
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{0}", new string('-', i+1), new string('\u005c', edno), 
                    new string('*', (2*n-1)-2*i), new string('/', edno));
            }
        }
    }
}
