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
            int starsCount = 0;
            if (n % 2 == 0)
            {
                starsCount = 2;
            }
            else
            {
                starsCount = 1;
            }
            
            int leftRightCount = (n - starsCount) / 2;            
            Console.WriteLine("{0}{1}{0}", new string('-', leftRightCount), new string('*', starsCount));
            
           if (n > 2)
           {
               int dashesCount = leftRightCount - 1;
               for (int i = 0; i < (n - 3) / 2; i++)
               {
                   Console.WriteLine("{0}*{1}*{0}", new string('-', dashesCount), new string('-', starsCount + (2 * i)));
                   dashesCount--;
               }
               
               Console.WriteLine("*{0}*", new string('-', n - 2));               
               for (int i = (n - 3) / 2 - 1; i >= 0; i--)
               {
                   dashesCount++;
                   Console.WriteLine("{0}*{1}*{0}", new string('-', dashesCount), new string('-', starsCount + (2 * i)));
               }
               
               Console.WriteLine("{0}{1}{0}", new string('-', leftRightCount), new string('*', starsCount));
           }        
        }
    }
}
