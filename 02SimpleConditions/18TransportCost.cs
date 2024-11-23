using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18TransportCost
{
    class Program
    {
        static void Main(string[] args)
        {
            int kilometersCount = int.Parse(Console.ReadLine());
            string tariff = Console.ReadLine();
            double cost = 0.0;
            if (kilometersCount < 20)
            {
                if (tariff == "day")
                {
                    cost = 0.70 + kilometersCount * 0.79;
                }
                else if (tariff == "night")
                {
                    cost = 0.70 + kilometersCount * 0.90;
                }
            }
            else if (kilometersCount < 100)
            {
                cost = kilometersCount * 0.09;
            }
            else if (kilometersCount >= 100)
            {
                cost = kilometersCount * 0.06;
            }
            
            Console.WriteLine(Math.Round(cost, 2));
        }
    }
}
