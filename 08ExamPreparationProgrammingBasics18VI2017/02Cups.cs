using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Cups
{
    class Program
    {
        static void Main(string[] args)
        {
            int expectedGlassesCount = int.Parse(Console.ReadLine());
            int workersCount = int.Parse(Console.ReadLine());
            int workDaysCount = int.Parse(Console.ReadLine());

            decimal allHoursCount = (decimal)workersCount * workDaysCount * 8m;
            decimal glassesCount = Math.Floor(allHours / 5);
            decimal difference = Math.Abs(glassesCount - expectedGlassesCount);
            decimal sum = difference * 4.20m;
            if (glassesCount < expectedGlassesCount)
            {
                Console.WriteLine("Losses: {0:f2}", sum);
            }
            else 
            {
                Console.WriteLine("{0:f2} extra money", sum);
            }
        }
    }
}
