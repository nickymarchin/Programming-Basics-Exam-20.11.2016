using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishland
{
    class Fishland
    {
        static void Main(string[] args)
        {
            double skumriaPrice = double.Parse(Console.ReadLine());
            double cacaPrice = double.Parse(Console.ReadLine());
            double palmudKG = double.Parse(Console.ReadLine());
            double safridKG = double.Parse(Console.ReadLine());
            int midiKG = int.Parse(Console.ReadLine());

            double palmudPrice = skumriaPrice + 0.60 * skumriaPrice;
            double safridPrice = cacaPrice + 0.80 * cacaPrice;

            double midiPrice = 7.50;

            double palmud = palmudKG * palmudPrice;
            double safrid = safridKG * safridPrice;
            double midi = midiKG * midiPrice;

            double result = palmud + safrid + midi;

            Console.WriteLine("{0:F2}", result);

        }
    }
}
