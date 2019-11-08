using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var cinemaTyp = Console.ReadLine();
            var r = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());
            double income = 0.0;
            if (cinemaTyp == "Premiere")
            {
                income = r * c * 12.00;
            }
            else if (cinemaTyp == "Normal")
            {
                income = r * c * 7.50;
            }
            else if (cinemaTyp == "Discount")
            {
                income = r * c * 5.00;
            }
            Console.WriteLine("{0:f2} leva", income);
        }
    }
}
