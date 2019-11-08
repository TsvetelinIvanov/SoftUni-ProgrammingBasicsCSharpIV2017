using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03PointInSegment
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEnd = int.Parse(Console.ReadLine());
            int secondtEnd = int.Parse(Console.ReadLine());
            int point = int.Parse(Console.ReadLine());

            if (firstEnd <= secondtEnd)
            {
                if (point >= firstEnd && point <= secondtEnd)
                {
                    Console.WriteLine("in");
                }
                else
                {
                    Console.WriteLine("out");
                }
            }
            else
            {
                if (point >= secondtEnd && point <= firstEnd)
                {
                    Console.WriteLine("in");
                }
                else
                {
                    Console.WriteLine("out");
                }
            }

            int distance1 = Math.Abs(point - firstEnd);
            int distance2 = Math.Abs(point - secondtEnd);
            int distance = Math.Min(distance1, distance2);
            Console.WriteLine(distance);
        }
    }
}
