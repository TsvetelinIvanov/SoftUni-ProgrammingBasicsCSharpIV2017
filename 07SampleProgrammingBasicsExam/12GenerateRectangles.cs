using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12GenerateRectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            bool found = false;
            for (int i1 = - n; i1 <= 0; i1++)
            {
                for (int i2 = n; i2 >= 0; i2--)
                {
                    for (int i3 = - n; i3 <= 0; i3++)
                    {
                        for (int i4 = n; i4 >= 0; i4--)
                        {
                            if (- n <= i1 && i1 < i2 && i2 <= n && - n <= i3 && i3 < i4 && i4 <= n)
                            { 
                                int side1 = Math.Abs(i1) + Math.Abs(i2);
                                int side2 = Math.Abs(i3) + Math.Abs(i4);                            
                                if (side1 * side2 >= m)
                                {
                                    Console.WriteLine("({0}, {1}) ({2}, {3}) -> {4}", i1, i3, i2, i4, side1 * side2);
                                    found = true;
                                }
                            }
                        }
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("No");
            }
        }
    }
}
