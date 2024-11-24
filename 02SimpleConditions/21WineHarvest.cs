using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21WineHarvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());
            int Z = int.Parse(Console.ReadLine());
            int W = int.Parse(Console.ReadLine());
            
            double grapes = X * Y;
            double wine = (0.4 * grapes) / 2.5;
            double differenceWine = Math.Abs(wine - Z);
            if (wine < Z)
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(differenceWine));
            }
            else
            {
                double winePerW = differenceWine / W;
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(wine));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(differenceWine), Math.Ceiling(winePerW));
            }
        }
    }
}
