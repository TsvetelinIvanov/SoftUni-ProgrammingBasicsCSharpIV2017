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
            int stadionCapacity = int.Parse(Console.ReadLine());
            int fansCount = int.Parse(Console.ReadLine());
            
            int fansInSectorA = 0;
            int fansInSectorB = 0;
            int fansInSectorV = 0;
            int fansInSectorG = 0;

            for (int i = 0; i < fansCount; i++)
            {
                string sector = Console.ReadLine();
                switch (sector)
                {
                    case "A":
                        fansInSectorA++;
                        break;
                    case "B":
                        fansInSectorB++;
                        break;
                    case "V":
                        fansInSectorV++;
                        break;
                    case "G":
                        fansInSectorG++;
                        break;
                }
            }

            double sectorAPercent = fansInSectorA * 100.0 / fansCount;
            double sectorBPercent = fansInSectorB * 100.0 / fansCount;
            double sectorVPercent = fansInSectorV * 100.0 / fansCount;
            double sectorGPercent = fansInSectorG * 100.0 / fansCount;
            double totalPercent = fansCount * 100.0 / stadionCapacity;

            Console.WriteLine("{0:f2}%", sectorAPercent);
            Console.WriteLine("{0:f2}%", sectorBPercent);
            Console.WriteLine("{0:f2}%", sectorVPercent);
            Console.WriteLine("{0:f2}%", sectorGPercent);
            Console.WriteLine("{0:f2}%", totalPercent);
        }
    }
}
