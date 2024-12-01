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
            int starsCount = 0;
            if (n % 2 == 0)
            {
                starsCount = 2;
            }
            else
            {
                starsCount = 1;
            }
            
            for (int i = 0; i < (n + 1) / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('-', (n - starsCount) / 2), new string('*', starsCount));
                starsCount += 2;
            }
            
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("|{0}|", new string('*', n - 2));
            }
        }
    }
}
