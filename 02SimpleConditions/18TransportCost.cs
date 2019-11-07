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
            int km = int.Parse(Console.ReadLine());
            string tarifa = Console.ReadLine();
            double cost = 0.0;
            if (km < 20)
            {
                if (tarifa == "day")
                {
                    cost = 0.70 + km * 0.79;
                }
                else if (tarifa == "night")
                {
                    cost = 0.70 + km * 0.90;
                }
            }
            else if (km < 100)
            {
                cost = km * 0.09;
            }
            else if (km >= 100)
            {
                cost = km * 0.06;
            }
            Console.WriteLine(Math.Round(cost, 2));
        }
    }
}
