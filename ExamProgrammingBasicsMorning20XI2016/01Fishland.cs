using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double mackerelPrice = double.Parse(Console.ReadLine());
            double spratlPrice = double.Parse(Console.ReadLine());
            double beltedBonitoQuontity = double.Parse(Console.ReadLine());
            double scadQuontity = double.Parse(Console.ReadLine());
            int musselQuontity = int.Parse(Console.ReadLine());

            double beltedBonitoPrice = mackerelPrice + mackerelPrice * 0.6;
            double scadPrice = spratlPrice + spratlPrice * 0.8;
            double beltedBonitoCost = beltedBonitoQuontity * beltedBonitoPrice;
            double scadCost = scadQuontity * scadPrice;
            double musselCost = 7.5 * musselQuontity;
            double totalCost = beltedBonitoCost + scadCost + musselCost;

            Console.WriteLine("{0:f2}", totalCost);
        }
    }
}
