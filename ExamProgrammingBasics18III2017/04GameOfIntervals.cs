using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int moves = int.Parse(Console.ReadLine());
            double score = 0.0;
            double from0To9 = 0.0;
            double from10To19 = 0.0;
            double from20To29 = 0.0;
            double from30To39 = 0.0;
            double from40To50 = 0.0;
            double invalidNumbers = 0.0;

            for (int i = 0; i < moves; i++)
            {
                double move = double.Parse(Console.ReadLine());
                if (move >= 0 && move <= 9)
                {
                    score += move * 0.2;
                    from0To9++;
                }
                else if (move >= 0 && move <= 19)
                {
                    score += move * 0.3;
                    from10To19++;
                }
                else if (move >= 0 && move <= 29)
                {
                    score += move * 0.4;
                    from20To29++;
                }
                else if (move >= 0 && move <= 39)
                {
                    score += 50;
                    from30To39++;
                }
                else if (move >= 0 && move <= 50)
                {
                    score += 100;
                    from40To50++;
                }
                else
                {
                    score /= 2;
                    invalidNumbers++;
                }
            }

            double from0To9Percent = from0To9 * 100.0 / moves;
            double from10To19Percent = from10To19 * 100.0 / moves;
            double from20To29Percent = from20To29 * 100.0 / moves;
            double from30To39Percent = from30To39 * 100.0 / moves;
            double from40To50Percent = from40To50 * 100.0 / moves;
            double invalidNumbersPercent = invalidNumbers * 100.0 / moves;

            Console.WriteLine("{0:f2}", score);
            Console.WriteLine("From 0 to 9: {0:f2}%", from0To9Percent);
            Console.WriteLine("From 10 to 19: {0:f2}%", from10To19Percent);
            Console.WriteLine("From 20 to 29: {0:f2}%", from20To29Percent);
            Console.WriteLine("From 30 to 39: {0:f2}%", from30To39Percent);
            Console.WriteLine("From 40 to 50: {0:f2}%", from40To50Percent);
            Console.WriteLine("Invalid numbers: {0:f2}%", invalidNumbersPercent);
        }
    }
}
