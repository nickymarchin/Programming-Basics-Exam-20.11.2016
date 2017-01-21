using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Pokemoni
{
    class Program
    {
        static void Main(string[] args)
        {
            int player1 = int.Parse(Console.ReadLine());
            int player2 = int.Parse(Console.ReadLine());
            int maxFights = int.Parse(Console.ReadLine());

            int fights = 0;

            for (int i = 1; i <= player1; i++)
            {
                for (int j = 1; j <= player2; j++)
                {
                    fights += 1;

                    if (fights > maxFights)
                    {
                        break;
                    }

                    Console.Write("({0} <-> {1}) ", i, j);
                }
            }

        }
    }
}
