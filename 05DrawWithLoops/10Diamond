using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int star = 0;
            if (n % 2 == 0)
            {
                star = 2;
            }
            else
            {
                star = 1;
            }
            int leftRight = (n - star) / 2;
            
            Console.WriteLine("{0}{1}{0}", new string('-', leftRight), new string('*', star));
            
           if (n > 2)
           {
               int dash = leftRight - 1;
               for (int i = 0; i < (n - 3) / 2; i++)
               {
                   Console.WriteLine("{0}*{1}*{0}", new string('-', dash), new string('-', star + (2 * i)));
                   dash--;
               }
               Console.WriteLine("*{0}*", new string('-', n - 2));
               
               for (int i = (n - 3) / 2 - 1; i >= 0; i--)
               {
                   dash++;
                   Console.WriteLine("{0}*{1}*{0}", new string('-', dash), new string('-', star + (2 * i)));
               }
               Console.WriteLine("{0}{1}{0}", new string('-', leftRight), new string('*', star));
           }        
        }
    }
}
