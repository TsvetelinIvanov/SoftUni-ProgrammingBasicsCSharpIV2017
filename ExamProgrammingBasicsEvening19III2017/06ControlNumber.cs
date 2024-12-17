using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06ControlNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());
            
            int counter = 0;
            int number = 0;
            for (int n = 1; n <= N; n++)
            {
                for (int m = M; m >= 1; m--)
                {
                    number += (n * 2 + m * 3);
                    counter++;
                    if (number >= controlNumber)
                    {
                        break;
                    }
                }
                
                if (number >= controlNumber)
                {
                    break;
                }
            }

            if (number >= controlNumber)
            {
                Console.WriteLine("{0} moves", counter);
                Console.WriteLine("Score: {0} >= {1}", number, controlNumber);
            }
            else
            {
                Console.WriteLine("{0} moves", counter);
            }
        }
    }
}
