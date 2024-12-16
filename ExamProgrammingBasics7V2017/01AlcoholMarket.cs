using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskyPrice = double.Parse(Console.ReadLine());
            double beerVolume = double.Parse(Console.ReadLine());
            double wineVolume = double.Parse(Console.ReadLine());
            double rakiaVolume = double.Parse(Console.ReadLine());
            double whiskyVolume = double.Parse(Console.ReadLine());

            double rakiaPrice = whiskyPrice / 2;
            double winePrice = rakiaPrice - (rakiaPrice * 0.4);
            double beerPrice = rakiaPrice - (rakiaPrice * 0.8);

            double rakiaSum = rakiaVolume * rakiaPrice;
            double wineSum = wineVolume * winePrice;
            double beerSum = beerPrice * beerVolume;
            double whiskySum = whiskyVolume * whiskyPrice;
            
            double alcoholSum = rakiaSum + wineSum + beerSum + whiskySum;

            Console.WriteLine("{0:f2}", alcoholSum);
        }
    }
}
