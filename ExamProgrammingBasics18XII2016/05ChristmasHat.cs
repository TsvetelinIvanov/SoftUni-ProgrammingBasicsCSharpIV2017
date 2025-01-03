using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05ChristmasHat
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 4 * n + 1;

            Console.WriteLine(@"{0}/|\{0}", new string('.', 2 * n - 1));
            Console.WriteLine(@"{0}\|/{0}", new string('.', 2 * n - 1));
            for (int i = 0; i < 2 * n; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', 2 * n - 1 - i), new string('-', i));
            }

            Console.WriteLine(new string('*', width));
            for (int i = 0; i < n * 2; i++)
            {
                Console.Write("*.");
            }
            
            Console.WriteLine("*");

            Console.WriteLine(new string('*', width));
        }
    }
}
