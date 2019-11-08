using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string gender = Console.ReadLine();
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            string sport = String.Empty;
            double price = 0.0;

            switch (season)
            {
                case "Winter": 
                    {
                        switch(gender)
                        {
                            case "boys": price = 9.60; sport = "Judo"; break;
                            case "girls": price = 9.60; sport = "Gymnastics"; break;
                            case "mixed": price = 10; sport = "Ski"; break;
                        }
                        break;
                   }
                case "Spring":
                    {
                        switch (gender)
                        {
                            case "boys": price = 7.20; sport = "Tennis"; break;
                            case "girls": price = 7.20; sport = "Athletics"; break;
                            case "mixed": price = 9.50; sport = "Cycling"; break;
                        }
                        break;
                    }
                case "Summer":
                    {
                        switch (gender)
                        {
                            case "boys": price = 15; sport = "Football"; break;
                            case "girls": price = 15; sport = "Volleyball"; break;
                            case "mixed": price = 20; sport = "Swimming"; break;
                        }
                        break;
                    }
            }
            double totalCost = price * students * nights;

            if (students >= 50)
            {
                totalCost *= 0.5;
            }
            else if (students >= 20)
            {
                totalCost *= 0.85;
            }
            else if (students >= 10)
            {
                totalCost *= 0.95;
            }

            Console.WriteLine("{0} {1:f2} lv.", sport, totalCost);
        }
    }
}
