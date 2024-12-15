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
            int partsCount = int.Parse(Console.ReadLine());
            double awardFor1Point = double.Parse(Console.ReadLine());
            
            double pointsCount = 0.0;
            for (int i = 1; i <= partsCount; i++)
            {
                double partPointsCount = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    pointsCount += 2 * partPointsCount;
                }
                else
                {
                    pointsCount += partPointsCount;
                }
            }

            double award = pointsCount * awardFor1Point;
            Console.WriteLine("The project prize was {0:f2} lv.", award);
        }
    }
}
