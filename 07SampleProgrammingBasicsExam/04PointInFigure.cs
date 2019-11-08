using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04PointInFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            bool checF1 = (x >= 2 && x <= 4) && (y >= -3 && y <= 1);
            bool checF2 = (x >= 4 && x <= 10) && (y >= -5 && y <= 3);
            bool checF3 = (x >= 10 && x <= 12) && (y >= -3 && y <= 1);

            if (checF1)
            {
                Console.WriteLine("in");
            }
            else if (checF2)
            {
                Console.WriteLine("in");
            }
            else if (checF3)
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }
        }
    }
}
