using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var star = 0;
            if (n % 2 == 0)
            {
                star = 2;
            }
            else
            {
                star = 1;
            }
            
            for (int i = 0; i < (n + 1) / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('-', (n - star) / 2), new string('*', star));
                star += 2;
            }
            
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("|{0}|", new string('*', n - 2));
            }
        }
    }
}
