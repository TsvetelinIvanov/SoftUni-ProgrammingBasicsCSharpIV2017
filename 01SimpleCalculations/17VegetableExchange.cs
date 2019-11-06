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
            var vegetablePrice = double.Parse(Console.ReadLine());
            var fruitPrice = double.Parse(Console.ReadLine());
            var vegetableWeight = int.Parse(Console.ReadLine());
            var fruitWeight = int.Parse(Console.ReadLine());

            var benefit = ((vegetablePrice * vegetableWeight) + (fruitPrice * fruitWeight)) / 1.94;

            Console.WriteLine(benefit);
        }
    }
}
