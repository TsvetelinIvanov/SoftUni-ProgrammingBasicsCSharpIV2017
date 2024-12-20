using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            
            double price = 0.0;
            string location = string.Empty;
            string place = string.Empty;
            if (budget <= 1000)
            {
                place = "Camp";
                if (season == "Summer")
                {
                    location = "Alaska";
                    price = budget * 0.65;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    price = budget * 0.45;
                }
            }
            else if (budget <= 3000)
            {
                place = "Hut";
                if (season == "Summer")
                {
                    location = "Alaska";
                    price = budget * 0.8;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    price = budget * 0.6;
                }
            }
            else if (budget > 3000)
            {
                place = "Hotel";
                if (season == "Summer")
                {
                    location = "Alaska";
                    price = budget * 0.9;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    price = budget * 0.9;
                }
            }

            Console.WriteLine("{0} - {1} - {2:f2}", location, place, price);
        }
    }
}
