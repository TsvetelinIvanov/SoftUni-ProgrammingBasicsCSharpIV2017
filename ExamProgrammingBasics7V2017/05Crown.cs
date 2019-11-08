using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Crown
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("@{0}@{0}@", new string(' ', n - 2));
            Console.WriteLine("**{0}*{0}**", new string(' ', n - 3));

            int mid = 1;
            int air = n - 5;
            for (int i = 1; i <= (n / 2) - 2; i++)
            {
                Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*", new string('.', i), new string(' ', air), new string('.', mid));
                air -= 2;
                mid += 2;
            }

            Console.WriteLine("*{0}*{1}*{0}*", new string('.', (n / 2) - 1), new string('.', mid));
            Console.WriteLine("*{0}{1}.{1}{0}*", new string('.', n / 2), new string('*', mid / 2));
            Console.WriteLine(new string('*', 2 * n - 1));
            Console.WriteLine(new string('*', 2 * n - 1));
        }
    }
}
