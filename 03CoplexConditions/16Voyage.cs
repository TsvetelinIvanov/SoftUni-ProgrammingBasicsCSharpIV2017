using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16Voyage
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double spentMoney = 0.0;
            if (budget <= 100) 
            {
                Console.WriteLine("Somewhere in Bulgaria");
                if (season == "summer")
                {
                    spentMoney = budget * 0.3;
                    Console.WriteLine("Camp - {0:f2}", spentMoney);
                }
                else if (season == "winter")
                {
                    spentMoney = budget * 0.7;
                    Console.WriteLine("Hotel - {0:f2}", spentMoney);
                }
            }
            else if (budget <= 1000) 
            {
                Console.WriteLine("Somewhere in Balkans");
                if (season == "summer")
                {
                    spentMoney = budget * 0.4;
                    Console.WriteLine("Camp - {0:f2}", spentMoney);
                }
                else if (season == "winter")
                {
                    spentMoney = budget * 0.8;
                    Console.WriteLine("Hotel - {0:f2}", spentMoney);
                }
            }
            else if (budget > 1000) 
            {
                Console.WriteLine("Somewhere in Europe");
                spentMoney = budget * 0.9;
                Console.WriteLine("Hotel - {0:f2}", spentMoney);                
            }
        }
    }
}
