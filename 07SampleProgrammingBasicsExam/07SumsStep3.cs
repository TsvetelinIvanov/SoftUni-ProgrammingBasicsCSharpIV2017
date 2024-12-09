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
            
            int count1 = 1;
            int count2 = 2;
            int count3 = 3;

            for (int i = 1; i <= n; i++)
            {                
                int nSum = int.Parse(Console.ReadLine());
                if (i == count1)
                {
                    sum1 += nSum;
                    count1 += 3;
                }
                else if (i == count2)
                {
                    sum2 += nSum;
                    count2 += 3;
                }
                else if (i == count3)
                {
                    sum3 += nSum;
                    count3 += 3;
                }
            } 
           
            Console.WriteLine("sum1 = " + sum1);
            Console.WriteLine("sum2 = " + sum2);
            Console.WriteLine("sum3 = " + sum3);
        }
    }
}
