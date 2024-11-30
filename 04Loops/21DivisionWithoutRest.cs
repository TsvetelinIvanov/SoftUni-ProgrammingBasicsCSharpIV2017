using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21DivisionWithoutRest
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            double count1 = 0;
            double count2 = 0;
            double count3 = 0;
            
            double percent1 = 0;
            double percent2 = 0;
            double percent3 = 0;

            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(Console.ReadLine());                
                if (m % 2 == 0)
                {
                    count1 += 1;
                    percent1 = count1 / n * 100;
                }
                
                if (m % 3 == 0)
                {
                    count2 += 1;
                    percent2 = count2 / n * 100;
                }
                
                if (m % 4 == 0)
                {
                    count3 += 1;
                    percent3 = count3 / n * 100;
                }
            }
            
            Console.WriteLine("{0:f2}%", percent1);
            Console.WriteLine("{0:f2}%", percent2);
            Console.WriteLine("{0:f2}%", percent3);
        }
    }
}
