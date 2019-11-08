using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int chrysanthemumQuontity = int.Parse(Console.ReadLine());
            int roseQuontity = int.Parse(Console.ReadLine());
            int tulipQuontity = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string day = Console.ReadLine();
            double chrysanthemumPrice = 0.0;
            double rosePrice = 0.0;
            double tulipPrice = 0.0;

            switch (season)
            {
                case "Spring":
                case "Summer": chrysanthemumPrice = 2.0; rosePrice = 4.1; tulipPrice = 2.5; break;
                case "Autumn":
                case "Winter": chrysanthemumPrice = 3.75; rosePrice = 4.5; tulipPrice = 4.15; break;
            }

            double flowerPrice = chrysanthemumPrice * chrysanthemumQuontity + rosePrice * roseQuontity + tulipPrice * tulipQuontity;

            if (day == "Y") flowerPrice += flowerPrice * 0.15;

            if (tulipQuontity > 7 && season == "Spring") flowerPrice -= flowerPrice * 0.05;

            if (roseQuontity >= 10 && season == "Winter") flowerPrice -= flowerPrice * 0.1;

            if ((chrysanthemumQuontity + roseQuontity + tulipQuontity) > 20) flowerPrice -= flowerPrice * 0.2;

            flowerPrice += 2;
            Console.WriteLine("{0:f2}", flowerPrice);
        }
    }
}
