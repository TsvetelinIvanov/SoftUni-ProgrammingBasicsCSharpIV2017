using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double count1 = 0;
            double count2 = 0;
            double count3 = 0;
            double count4 = 0;
            double count5 = 0;
            double percent1 = 0;
            double percent2 = 0;
            double percent3 = 0;
            double percent4 = 0;
            double percent5 = 0;

            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(Console.ReadLine());
                
                if (m >= 1 && m <= 199)
                {
                    count1 += 1;
                    percent1 = count1 / n * 100;
                }
                
                if (m >= 200 && m <= 399)
                {
                    count2 += 1;
                    percent2 = count2 / n * 100;
                }
                
                if (m >= 400 && m <= 599)
                {
                    count3 += 1;
                    percent3 = count3 / n * 100;
                }
                
                if (m >= 600 && m <= 799)
                {
                    count4 += 1;
                    percent4 = count4 / n * 100;
                }
                
                if (m >= 800 && m <= 1000)
                {
                    count5 += 1;
                    percent5 = count5 / n * 100;
                }
            }
            
            Console.WriteLine("{0:f2}%", percent1);
            Console.WriteLine("{0:f2}%", percent2);
            Console.WriteLine("{0:f2}%", percent3);
            Console.WriteLine("{0:f2}%", percent4);
            Console.WriteLine("{0:f2}%", percent5);
        }
    }
}
