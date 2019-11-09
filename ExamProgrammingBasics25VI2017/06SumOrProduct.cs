using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06SumOrProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int counter = 0;
            for (int n1 = 1; n1 <= 30; n1++)
            {
                for (int n2 = 1; n2 <= 30; n2++)
                {
                    for (int n3 = 1; n3 <= 30; n3++)
                    {
                        if (n1 + n2 + n3 == n && n1 < n2 && n2 < n3)
                        {
                            Console.WriteLine("{0} + {1} + {2} = {3}", n1, n2, n3, n);
                        }
                        else
                        {
                            counter++;
                        }

                        if (n1 * n2 * n3 == n && n1 > n2 && n2 > n3)
                        {
                            Console.WriteLine("{0} * {1} * {2} = {3}", n1, n2, n3, n);
                        }
                        else
                        {
                            counter++;
                        }                        
                    }
                }
            }

            if (counter == 2 * 30 * 30 * 30)
            {
                Console.WriteLine("No!");
            }
        }
    }
}
