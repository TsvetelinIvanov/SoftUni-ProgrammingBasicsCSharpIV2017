using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOnRectangleBorder3D
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double z1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double z2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());

            bool checkX = (x == x1 || x == x2) && (y >= y1 && y <= y2) && (z >= z1 && z <= z2);
            bool checkY = (y == y1 || y == y2) && (x >= x1 && x <= x2) && (z >= z1 && z <= z2);
            bool checkZ = (z == z1 || z == z2) && (x >= x1 && x <= x2) && (y >= y1 && y <= y2);


            if (checkX || checkY || checkZ)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
