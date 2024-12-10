using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniorsCount = int.Parse(Console.ReadLine());
            int seniorsCount = int.Parse(Console.ReadLine());
            string place = Console.ReadLine().ToLower();
            decimal feesNumber = 0;
            switch (place)
            {
                case "trail":
                    feesNumber = juniorsCount * 5.50m + seniorsCount * 7m;
                    break;
                case "cross-country":
                    taxes = juniorsCount * 8m + seniorsCount * 9.50m;
                    if (juniorsCount + seniorsCount >= 50)
                    {
                        feesNumber = feesNumber - (feesNumber * 0.25m);
                    }
                    
                    break;
                case "downhill":
                    feesNumber = juniorsCount * 12.25m + seniorsCount * 13.750m;
                    break;
                case "road":
                    feesNumber = juniorsCount * 20m + seniorsCount * 21.50m;
                    break;
            }

            decimal finalFeesNumber = feesNumber - (feesNumber * 0.05m);
            Console.WriteLine("{0:f2}", finalFeesNumber);
        }
    }
}
