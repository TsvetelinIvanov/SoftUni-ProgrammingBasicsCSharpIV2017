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
            int puselsQuontity = int.Parse(Console.ReadLine());
            int dollsQuontity = int.Parse(Console.ReadLine());
            int teddybearsQuontity = int.Parse(Console.ReadLine());
            int minionsQuontity = int.Parse(Console.ReadLine());
            int lorriesQuontity = int.Parse(Console.ReadLine());

            double toysPriceSum = puselsQuontity * 2.60 + dollsQuontity * 3 + teddybearsQuontity * 4.10 + minionsQuontity * 8.20 + lorriesQuontity * 2;
            double toysQuontity = (double)puselsQuontity + dollsQuontity + teddybearsQuontity + minionsQuontity + lorriesQuontity;
            if (toysQuontity >= 50)
            {
                toysPriceSum -= toyPriceSum * 0.25;
            }

            double finalToysPriceSum = toysPriceSum - toysPriceSum * 0.10;
            if (finalToysPriceSum >= excursionPrice)
            {
                Console.WriteLine("Yes! {0:f2} lv left.", finalToysPriceSum - excursionPrice);
            }            
            else               
            {
               Console.WriteLine("Not enough money! {0:f2} lv needed.", excursionPrice - finalToysPriceSum);
            }
        }
    }
}
