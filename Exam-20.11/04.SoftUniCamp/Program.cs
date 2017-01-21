using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftUniCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupsNum = int.Parse(Console.ReadLine());

            double group1 = 0;
            double group2 = 0;
            double group3 = 0;
            double group4 = 0;
            double group5 = 0;

            double sum = 0;

            for (int i = 0; i < groupsNum; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number <= 5)
                {
                    group1 += number;
                }
                else if (number >= 6 && number <= 12)
                {
                    group2 += number;
                }
                else if (number >= 13 && number <= 25)
                {
                    group3 += number;
                }
                else if (number >= 26 && number <= 40)
                {
                    group4 += number;
                }
                else if (number >= 41)
                {
                    group5 += number;
                }

                sum += number;
            }

            Console.WriteLine("{0:F2}%", group1 * 100 / sum);
            Console.WriteLine("{0:F2}%", group2 * 100 / sum);
            Console.WriteLine("{0:F2}%", group3 * 100 / sum);
            Console.WriteLine("{0:F2}%", group4 * 100 / sum);
            Console.WriteLine("{0:F2}%", group5 * 100 / sum);
        }
    }
}
