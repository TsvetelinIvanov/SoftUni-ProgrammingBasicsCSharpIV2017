using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02BrickCarrying
{
    class Program
    {
        static void Main(string[] args)
        {
            int brickCount = int.Parse(Console.ReadLine());
            int workerCount = int.Parse(Console.ReadLine());
            int wheelbarrowVolume = int.Parse(Console.ReadLine());
            double course = (double)brickCount / (workerCount * wheelbarrowVolume);
            Console.WriteLine(Math.Ceiling(course));
        }
    }
}
