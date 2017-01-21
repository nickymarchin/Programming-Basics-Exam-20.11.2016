using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int oldPeople = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            int nightsNum = int.Parse(Console.ReadLine());
            string transport = Console.ReadLine();

            int groupNum = oldPeople + students;
            double nightsPrice = nightsNum * 82.99;

            double studentsTickets = 0;
            double oldTickets = 0;

            if (transport == "train")
            {
                if (groupNum >= 50)
                {
                    oldTickets = 0.50 * 24.99;
                    studentsTickets = 0.50 * 14.99;
                }
                else
                {
                    oldTickets = 24.99;
                    studentsTickets = 14.99;
                }
            }
            else if (transport == "bus")
            {
                oldTickets = 32.50;
                studentsTickets = 28.50;
            }
            else if (transport == "boat")
            {
                oldTickets = 42.99;
                studentsTickets = 39.99;
            }
            else if (transport == "airplane")
            {
                oldTickets = 70.00;
                studentsTickets = 50.00;
            }

            double studentPrice = studentsTickets * students * 2;
            double oldPrice = oldTickets * oldPeople * 2;

            double sum = studentPrice + oldPrice + nightsPrice;
            double allSum = 0.10 * sum + sum;

            Console.WriteLine("{0:F2}", allSum);

        }
    }
}
