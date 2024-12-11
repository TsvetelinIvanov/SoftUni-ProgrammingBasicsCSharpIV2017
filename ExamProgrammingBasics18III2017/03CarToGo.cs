using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03CarToGo
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            
            double price = 0.0;
            string carType = string.Empty;
            string carClass = string.Empty;
            if (budget <= 100)
            {
                carClass = "Economy class";
                if (season == "Summer")
                {
                    carType = "Cabrio"; price = budget * 0.35;                    
                }
                else
                {
                    carType = "Jeep"; price = budget * 0.65;
                }
            }
            else if (budget <= 500)
            {
                carClass = "Compact class";
                if (season == "Summer")
                {
                    carType = "Cabrio"; price = budget * 0.45;
                }
                else
                {
                    carType = "Jeep"; price = budget * 0.80;
                }
            }
            else
            {
                carClass = "Luxury class";
                carType = "Jeep"; price = budget * 0.9;                
            }

            Console.WriteLine(carClass);
            Console.WriteLine("{0} - {1:f2}", carType, price);
        }
    }
}
