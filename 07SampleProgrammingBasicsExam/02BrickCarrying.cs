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
            int bricksCount = int.Parse(Console.ReadLine());
            int workersCount = int.Parse(Console.ReadLine());
            int wheelbarrowVolume = int.Parse(Console.ReadLine());
            
            double courses = (double)bricksCount / (workersCount * wheelbarrowVolume);
            Console.WriteLine(Math.Ceiling(courses));
        }
    }
}
