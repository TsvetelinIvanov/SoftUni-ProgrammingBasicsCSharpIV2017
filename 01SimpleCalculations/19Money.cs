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
            var bitcoin = int.Parse(Console.ReadLine());
            var CNY = double.Parse(Console.ReadLine());
            var percentage = double.Parse(Console.ReadLine());

            var BGN = bitcoin * 1168;
            var USD = (CNY * 0.15) * 1.76;
            var EUR = (BGN + USD) / 1.95;

            var commission = (EUR / 100) * percentage;
            var money = EUR - commission;

            Console.WriteLine(money);
        }
    }
}
