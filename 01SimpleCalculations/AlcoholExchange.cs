using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlcoholExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            var whiskyPrice = double.Parse(Console.ReadLine());
            var beerVolume = double.Parse(Console.ReadLine());
            var wineVolume = double.Parse(Console.ReadLine());
            var rakiaVolume = double.Parse(Console.ReadLine());
            var whiskyVolume = double.Parse(Console.ReadLine());

            var rakiaPrice = whiskyPrice / 2;
            var winePrice = rakiaPrice - (rakiaPrice * 0.4);
            var beerPrice = rakiaPrice - (rakiaPrice * 0.8);

            var rakiaSum = rakiaVolume * rakiaPrice;
            var wineSum = wineVolume * winePrice;
            var beerSum = beerPrice * beerVolume;
            var whiskySum = whiskyVolume * whiskyPrice;

            double alcoholSum = rakiaSum + wineSum + beerSum + whiskySum;

            Console.WriteLine("{0:f2}", alcoholSum);
        }
    }
}
