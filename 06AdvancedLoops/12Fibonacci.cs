using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int f1 = 0;
            int f2 = 1;
            for (int i = 0; i < n; i++)
            {
                int fNext = f1 + f2;
                f1 = f2;
                f2 = fNext;
            }

            Console.WriteLine(f2);
        }
    }
}
