using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01GrapeAndRakia
{
    class Program
    {
        static void Main(string[] args)
        {
            double vineyardArea = double.Parse(Console.ReadLine());
            double kiloPerSquare = double.Parse(Console.ReadLine());
            double waste = double.Parse(Console.ReadLine());

            double yieldQuantity = vineyardArea * kiloPerSquare - waste;
            double rakiaQuantity = (yieldQuantity * 0.45) / 7.5;
            double rakiaIncome = rakiaQuantity * 9.8;
            double grapeIncome = (yieldQuantity * 0.55) * 1.5;

            Console.WriteLine("{0:f2}", rakiaIncome);
            Console.WriteLine("{0:f2}", grapeIncome);
        }
    }
}
