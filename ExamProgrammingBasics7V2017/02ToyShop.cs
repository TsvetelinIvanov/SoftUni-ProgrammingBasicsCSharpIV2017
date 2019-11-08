using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double excursionPrice = double.Parse(Console.ReadLine());
            int puselQuontity = int.Parse(Console.ReadLine());
            int dolllQuontity = int.Parse(Console.ReadLine());
            int teddybeerlQuontity = int.Parse(Console.ReadLine());
            int minionQuontity = int.Parse(Console.ReadLine());
            int lorryQuontity = int.Parse(Console.ReadLine());

            double toyPriceSum = puselQuontity * 2.60 + dolllQuontity * 3 + teddybeerlQuontity * 4.10 + minionQuontity * 8.20 + lorryQuontity * 2;
            double toyQuontity = (double)puselQuontity + dolllQuontity + teddybeerlQuontity + minionQuontity + lorryQuontity;
            if (toyQuontity >= 50)
            {
                toyPriceSum -= toyPriceSum * 0.25;
            }

            double endToyPriceSum = toyPriceSum - toyPriceSum * 0.10;
            if (endToyPriceSum >= excursionPrice)
            {
                Console.WriteLine("Yes! {0:f2} lv left.", endToyPriceSum - excursionPrice);
            }            
            else               
            {
               Console.WriteLine("Not enough money! {0:f2} lv needed.", excursionPrice - endToyPriceSum);
            }
        }
    }
}
