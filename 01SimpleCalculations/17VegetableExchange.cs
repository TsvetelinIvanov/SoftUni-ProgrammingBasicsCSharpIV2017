using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17VegetableExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegetablePrice = double.Parse(Console.ReadLine());
            double fruitPrice = double.Parse(Console.ReadLine());
            int vegetableWeight = int.Parse(Console.ReadLine());
            int fruitWeight = int.Parse(Console.ReadLine());

            double benefit = ((vegetablePrice * vegetableWeight) + (fruitPrice * fruitWeight)) / 1.94;

            Console.WriteLine(benefit);
        }
    }
}
