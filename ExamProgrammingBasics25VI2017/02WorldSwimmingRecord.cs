using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal record = decimal.Parse(Console.ReadLine());
            decimal distance = decimal.Parse(Console.ReadLine());
            decimal swimm1m = decimal.Parse(Console.ReadLine());

            decimal resistence1 = Math.Floor(distance / 15m) ;
            decimal resistence = resistence1 * 12.5m;

            decimal time = (distance * swimm1m) + resistence;

            if (time < record)
            {
                Console.WriteLine("Yes, he succeeded! The new world record is {0:f2} seconds.", time);
            }
            else
            {
                Console.WriteLine("No, he failed! He was {0:f2} seconds slower.", time - record);
            }
        }
    }
}
