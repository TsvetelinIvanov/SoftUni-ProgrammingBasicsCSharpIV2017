using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19Money
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoin = int.Parse(Console.ReadLine());
            double CNY = double.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            int BGN = bitcoin * 1168;
            double USD = (CNY * 0.15) * 1.76;
            double EUR = (BGN + USD) / 1.95;

            double commission = (EUR / 100) * percentage;
            double money = EUR - commission;

            Console.WriteLine(money);
        }
    }
}
