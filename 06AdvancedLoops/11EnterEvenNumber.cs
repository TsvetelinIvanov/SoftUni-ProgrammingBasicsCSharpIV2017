using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11EnterEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            while (true)
            {
                try
                {
                    Console.Write("Enter even number: ");
                    n = int.Parse(Console.ReadLine());
                    if (n % 2 == 0) 
                    {
                        break;
                    }
                    
                    Console.WriteLine("The number is not even.");
                }
                catch
                {
                    Console.WriteLine("Invalid number.");
                }
            }

            Console.WriteLine("Even number entered: " + n);
        }
    }
}
