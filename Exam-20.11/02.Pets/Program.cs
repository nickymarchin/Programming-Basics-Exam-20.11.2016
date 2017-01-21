using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysGone = int.Parse(Console.ReadLine());
            int foodKG = int.Parse(Console.ReadLine());

            double dogKG = double.Parse(Console.ReadLine());
            double catKG = double.Parse(Console.ReadLine());
            double turtleG = double.Parse(Console.ReadLine());

            double turtlrKG = turtleG / 1000;


            double allFoodNeeded = (dogKG + catKG + turtlrKG) * daysGone;
            double result = foodKG - allFoodNeeded;

            if (result < 0)
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(Math.Abs(foodKG - allFoodNeeded)));
            }
            else if (result == 0)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Ceiling(Math.Abs(foodKG - allFoodNeeded)));
            }
            else if (result > 0)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(Math.Abs(foodKG - allFoodNeeded)));
            }
        }
    }
}
