using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13PointInFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int x2 = h * 2;
            int x3 = h * 3;
            int y4 = h * 4;            
            if (((x > 0) && (x < x3) && (y > 0) && (y < h)) || ((x > h) && (x < x2) && (y >= h) && (y < y4)))
            {
                Console.WriteLine("inside");
            }           
            else if ((((x == 0 || x == x3) && (y >= 0 && y <= h)) || ((y == 0 || (y == h && (x < h || x > x2))) && (x >= 0 && x <= x3))) ||
                (((x == h || x == x2) && (y >= h && y <= y4)) || ((y == y4) && (x >= h && x <= x2))))
            {
                Console.WriteLine("border");
            }
            else 
            {
                Console.WriteLine("outside");
            }            
        }
    }
}
