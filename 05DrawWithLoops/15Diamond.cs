using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n * 3));
            
            int mid = n * 3;
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', n - i), new string('.', mid));
                mid += 2;
            }
            
            Console.WriteLine(new string('*', n * 5));
            
            for (int i = 1; i <= n * 2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', i), new string('.', mid - 2));
                mid -= 2;
            }
            
            Console.WriteLine("{0}{1}{0}", new string('.', n * 2 + 1), new string('*', n - 2));
        }
    }
}
