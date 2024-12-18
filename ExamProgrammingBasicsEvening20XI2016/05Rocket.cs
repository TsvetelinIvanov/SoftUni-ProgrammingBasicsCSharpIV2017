using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int middle = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(@"{0}/{1}\{0}", new string('.', n + (n / 2) - i), new string(' ', middle));
                middle += 2;
            }
            
            Console.WriteLine("{0}{1}{0}", new string('.', n / 2), new string('*', n * 2));
            for (int i = 0; i < n * 2; i++)
            {
                Console.WriteLine(@"{0}|{1}|{0}", new string('.', n / 2), new string('\\', n * 2 - 2));
            }
            
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine(@"{0}/{1}\{0}", new string('.', (n / 2) - i), new string('*', middle - 2));
                middle += 2;
            }
        }
    }
}
