using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07SumsStep3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;            
            for (int i = 0; i < n; i++)
            {
                int nSum = int.Parse(Console.ReadLine());
                if (i % 3 == 0)
                {
                    sum1 += nSum;                    
                }
                else if (i % 3 == 1)
                {
                    sum2 += nSum;                    
                }
                else if (i % 3 == 2)
                {
                    sum3 += nSum;                    
                }
            }

            Console.WriteLine("sum1 = " + sum1);
            Console.WriteLine("sum2 = " + sum2);
            Console.WriteLine("sum3 = " + sum3);
        }
    }
}
