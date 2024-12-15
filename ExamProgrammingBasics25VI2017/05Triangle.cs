using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = (4 * n) + 1;            
            int middle = 1;

            Console.WriteLine(new string('#', width));
            for (int i = 1; i <= n; i++)
            {              
                if (i == (n / 2) + 1)
                {
                    Console.WriteLine(@"{0}{1}{2}(@){2}{1}{0}", new string('.', i), new string('#', 2 * n - i - (middle / 2)), new string(' ', middle / 2 - 1));
                    middle += 2;
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', i), new string('#', 2 * n - i - (middle / 2)), new string(' ', middle));
                    middle += 2;
                }                    
            }                 
            
            middle -= 2; 
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', (width / 2) - (middle / 2)), new string('#', middle));
                middle -= 2;
            }
        }        
    }
}
