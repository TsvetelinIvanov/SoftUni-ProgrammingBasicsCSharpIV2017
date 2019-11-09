using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Hourglass
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = 2 * n + 1;
            Console.WriteLine(new string('*', width));
            Console.WriteLine(".*{0}*.", new string(' ', width - 4));
            for (int i = 2; i < n; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', i), new string('@', width - 2 - 2 * i));
            }
            Console.WriteLine("{0}*{0}", new string('.', n));
            for (int i = 0; i < n -2; i++)
            {
                Console.WriteLine("{0}*{1}@{1}*{0}", new string('.', n - 1 - i), new string(' ', i));
            }
            Console.WriteLine(".*{0}*.", new string('@', width - 4));
            Console.WriteLine(new string('*', width));
        }
    }
}
