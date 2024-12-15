using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_SumOrProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            bool isMatch = false;
            for (int n1 = 1; n1 <= 30; n1++)
            {
                for (int n2 = 1; n2 <= 30; n2++)
                {
                    for (int n3 = 1; n3 <= 30; n3++)
                    {
                        if (n1 < n2 && n2 < n3 && n1 + n2 + n3 == n)
                        { 
                            Console.WriteLine("{0} + {1} + {2} = {3}", n1, n2, n3, n);
                            isMatch = true;
                        }
                        
                        if (n1 > n2 && n2 > n3 && n1 * n2 * n3 == n)
                        { 
                            Console.WriteLine("{0} * {1} * {2} = {3}", n1, n2, n3, n);
                            isMatch = true;
                        }
                    }
                }
            }

            if (isMatch == false)
            {
                Console.WriteLine("No!");
            }
        }
    }
}
