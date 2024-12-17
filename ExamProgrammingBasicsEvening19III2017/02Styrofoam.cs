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
            int windowsCount = int.Parse(Console.ReadLine());
            double styrofoamQuantityInPack = double.Parse(Console.ReadLine());
            double styrofoamPackPrice = double.Parse(Console.ReadLine());

            double houseArea = house - (windowsCount * 2.4);
            double styrofoamQuantity = houseArea + houseArea * 0.10;
            double styrofoamCost = Math.Ceiling(styrofoamQuantity / styrofoamQuantityInPack) * styrofoamPackPrice;
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
