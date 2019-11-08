using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInRectangle5D
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var z1 = double.Parse(Console.ReadLine());
            var v1 = double.Parse(Console.ReadLine());
            var w1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var z2 = double.Parse(Console.ReadLine());
            var v2 = double.Parse(Console.ReadLine());
            var w2 = double.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            var z = double.Parse(Console.ReadLine());
            var v = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());

            bool checkX = (x >= x1) && (x <= x2);
            bool checkY = (y >= y1) && (y <= y2);
            bool checkZ = (z >= z1) && (z <= z2);
            bool checkV = (v >= v1) && (v <= v2);
            bool checkW = (w >= w1) && (w <= w2);

            if (checkX && checkY && checkZ && checkV && checkW)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Outside");
            }
        }
    }
}
