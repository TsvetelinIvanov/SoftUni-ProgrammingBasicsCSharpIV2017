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
            int glassesExpected = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int workDays = int.Parse(Console.ReadLine());

            decimal allHours = (decimal)workers * workDays * 8m;
            decimal glasses = Math.Floor(allHours / 5);
            decimal diff = Math.Abs(glasses - glassesExpected);
            decimal sum = diff * 4.20m;

            if (glasses < glassesExpected)
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
