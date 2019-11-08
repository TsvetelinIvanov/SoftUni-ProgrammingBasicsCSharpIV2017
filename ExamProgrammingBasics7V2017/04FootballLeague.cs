using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            int stadion = int.Parse(Console.ReadLine());
            int fans = int.Parse(Console.ReadLine());
            int sectorAfans = 0;
            int sectorBfans = 0;
            int sectorVfans = 0;
            int sectorGfans = 0;

            for (int i = 0; i < fans; i++)
            {
                var fan = Console.ReadLine();
                switch (fan)
                {
                    case "A": sectorAfans++; break;
                    case "B": sectorBfans++; break;
                    case "V": sectorVfans++; break;
                    case "G": sectorGfans++; break;
                }
            }

            double aPercent = sectorAfans * 100.0 / fans;
            double bPercent = sectorBfans * 100.0 / fans;
            double vPercent = sectorVfans * 100.0 / fans;
            double gPercent = sectorGfans * 100.0 / fans;
            double totalPercent = fans * 100.0 / stadion;

            Console.WriteLine("{0:f2}%", aPercent);
            Console.WriteLine("{0:f2}%", bPercent);
            Console.WriteLine("{0:f2}%", vPercent);
            Console.WriteLine("{0:f2}%", gPercent);
            Console.WriteLine("{0:f2}%", totalPercent);
        }
    }
}
