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
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double z1 = double.Parse(Console.ReadLine());
            double v1 = double.Parse(Console.ReadLine());
            double w1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double z2 = double.Parse(Console.ReadLine());
            double v2 = double.Parse(Console.ReadLine());
            double w2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            double v = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());

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
