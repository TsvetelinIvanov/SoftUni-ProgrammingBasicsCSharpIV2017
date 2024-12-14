using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstSpeed = int.Parse(Console.ReadLine());
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            decimal secondSpeed = (decimal)firstSpeed + firstSpeed * 0.1m;
            decimal thirdSpeed = (decimal)secondSpeed - secondSpeed * 0.05m;
            
            decimal fistDistance = firstSpeed * firstTime * 0.0166666666666666666666666666666666m;
            decimal secondDistance = secondSpeed * secondTime * 0.01666666666666666666666666666666666m;
            decimal thirdDistance = thirdSpeed * thirdTime * 0.0166666666666666666666666666666666m;
            decimal distance = fistDistance + secondDistance + thirdDistance;

            Console.WriteLine("{0:f2}", distance);
        }
    }
}
