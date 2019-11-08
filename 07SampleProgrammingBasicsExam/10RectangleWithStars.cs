using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10RectangleWithStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int side = 0;
            if (n % 2 == 0)
            {
                side = n - 1;
            }
            else
            {
                side = n;
            }

            Console.WriteLine(new string('%', n * 2));

            if (n == 2)
            {
                Console.WriteLine("%**%");
            }
            else 
            {
                for (int i = 0; i < side; i++)
                {
                    Console.WriteLine("%{0}%", new string(' ', n * 2 - 2));
                    if (i == side / 2 - 1)
                    {
                        Console.WriteLine("%{0}**{0}%", new string(' ', n - 2));
                        side--;
                    }
                }
            }

            Console.WriteLine(new string('%', n * 2));
        }
    }
}
