using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06NumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int L = int.Parse(Console.ReadLine());
            int specialNumber = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());
            
            for (int m = M; m >= 1; m--)
            {
                for (int n = N; n >= 1; n--)
                {
                    for (int l = L; l >= 1; l--)
                    {
                        int mnl = (m * 100) + (n * 10) + l;
                        if (mnl % 3 == 0)
                        {
                            specialNumber += 5;
                        }
                        else if (mnl % 10 == 5)
                        {
                            specialNumber -= 2;
                        }
                        else if (mnl % 2 == 0)
                        {
                            specialNumber *= 2;
                        }
                        
                        if (specialNumber >= controlNumber)
                        {
                            break;
                        }
                    }
                    
                    if (specialNumber >= controlNumber)
                    {
                        break;
                    }
                }
                if (specialNumber >= controlNumber)
                {
                    break;
                }
            }

            if (specialNumber >= controlNumber)
            {
                Console.WriteLine("Yes! Control number was reached! Current special number is {0}.", specialNumber);
            }
            else
            {
                Console.WriteLine("No! {0} is the last reached special number.", specialNumber);
            }
        }
    }
}
