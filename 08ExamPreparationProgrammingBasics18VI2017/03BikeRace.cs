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
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string place = Console.ReadLine().ToLower();
            decimal taxes = 0;

            switch (place)
            {
                case "trail": taxes = juniors * 5.50m + seniors * 7m; break;
                case "cross-country": taxes = juniors * 8m + seniors * 9.50m;
                    if (juniors + seniors >= 50)
                    {
                        taxes = taxes - (taxes * 0.25m);
                    }
                    break;
                case "downhill": taxes = juniors * 12.25m + seniors * 13.750m; break;
                case "road": taxes = juniors * 20m + seniors * 21.50m; break;
            }

            decimal result = taxes - (taxes * 0.05m);
            Console.WriteLine("{0:f2}", result);
        }
    }
}
