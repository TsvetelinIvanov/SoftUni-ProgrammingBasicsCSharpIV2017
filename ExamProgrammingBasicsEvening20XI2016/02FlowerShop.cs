using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnoliasCount = int.Parse(Console.ReadLine());
            int hyacinthsCount = int.Parse(Console.ReadLine());
            int rosesCount = int.Parse(Console.ReadLine());
            int cactusesCount = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double flowersIncome = 3.25 * magnoliasCount + 4.0 * hyacinthsCount + 3.5 * rosesCount + 8.0 * cactusesCount;
            flowersIncome -= flowersIncome * 0.05;
            if (flowersIncome >= giftPrice)
            {
                Console.WriteLine("She is left with {0} leva.", Math.Floor(flowersIncome - giftPrice));
            }
            else 
            {
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(giftPrice - flowersIncome));
            }
        }
    }
}
