using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11OddOrEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            double oddSum = 0.0;
            double oddMin = double.PositiveInfinity;
            double oddMax = double.NegativeInfinity;
            
            double evenSum = 0.0;
            double evenMin = double.PositiveInfinity;
            double evenMax = double.NegativeInfinity;
            
            if (n == 0)
            {
                Console.WriteLine("OddSum=0,");
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
                Console.WriteLine("EvenSum=0,");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    double m = double.Parse(Console.ReadLine());
                    if (i % 2 == 0)
                    {
                        evenSum += m;
                        if (m < evenMin)
                        {
                            evenMin = m;
                        }
                        
                        if (m > evenMax)
                        {
                            evenMax = m;
                        }
                    }
                    else
                    {
                        oddSum += m;
                        if (m < oddMin)
                        {
                            oddMin = m;
                        }
                        
                        if (m > oddMax)
                        {
                            oddMax = m;
                        }
                    }
                }
                
                if (oddSum == 0) 
                {
                    Console.WriteLine("OddSum={0},", oddSum);
                    Console.WriteLine("OddMin=No,");
                    Console.WriteLine("OddMax=No,");
                    Console.WriteLine("EvenSum={0},", evenSum);
                    Console.WriteLine("EvenMin={0},", evenMin);
                    Console.WriteLine("EvenMax={0}", evenMax);
                }
                else if (evenSum == 0)
                {
                    Console.WriteLine("OddSum={0},", oddSum);
                    Console.WriteLine("OddMin={0},", oddMin);
                    Console.WriteLine("OddMax={0},", oddMax);
                    Console.WriteLine("EvenSum={0},", evenSum);
                    Console.WriteLine("EvenMin=No,");
                    Console.WriteLine("EvenMax=No");
                }
                else if (evenSum == 0 && oddSum == 0)
                {
                    Console.WriteLine("OddSum={0},", oddSum);
                    Console.WriteLine("OddMin=No,");
                    Console.WriteLine("OddMax=No,");
                    Console.WriteLine("EvenSum={0},", evenSum);
                    Console.WriteLine("EvenMin=No,");
                    Console.WriteLine("EvenMax=No");
                }
                else
                {
                    Console.WriteLine("OddSum={0},", oddSum);
                    Console.WriteLine("OddMin={0},", oddMin);
                    Console.WriteLine("OddMax={0},", oddMax);
                    Console.WriteLine("EvenSum={0},", evenSum);
                    Console.WriteLine("EvenMin={0},", evenMin);
                    Console.WriteLine("EvenMax={0}", evenMax);
                }
            }
        }
    }
}
