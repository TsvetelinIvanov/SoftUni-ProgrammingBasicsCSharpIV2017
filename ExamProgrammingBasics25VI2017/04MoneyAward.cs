using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04MoneyAward
{
    class Program
    {
        static void Main(string[] args)
        {
            int parts = int.Parse(Console.ReadLine());
            double award1Point = double.Parse(Console.ReadLine());
            double points = 0.0;

            for (int i = 1; i <= parts; i++)
            {
                double partPoints = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    points += 2 * partPoints;
                }
                else
                {
                    points += partPoints;
                }
            }

            double award = points * award1Point;
            Console.WriteLine("The project prize was {0:f2} lv.", award);
        }
    }
}
