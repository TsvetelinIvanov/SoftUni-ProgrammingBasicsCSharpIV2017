using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Styrofoam
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double house = double.Parse(Console.ReadLine());
            int windows = int.Parse(Console.ReadLine());
            double styrofoamInPack = double.Parse(Console.ReadLine());
            double styrofoamPackPrice = double.Parse(Console.ReadLine());

            double houseArea = house - (windows * 2.4);
            double styrofoam = houseArea + houseArea * 0.10;
            double styrofoamCost = Math.Ceiling(styrofoam / styrofoamInPack) * styrofoamPackPrice;

            if (budget >= styrofoamCost)
            {
                Console.WriteLine("Spent: {0:f2}", styrofoamCost);
                Console.WriteLine("Left: {0:f2}", budget - styrofoamCost);
            }
            else
            {
                Console.WriteLine("Need more: {0:f2}", styrofoamCost - budget);
            }
        }
    }
}
