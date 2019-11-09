using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06TwoNumbersSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int stopNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            bool check = false;

            for (int i = startNumber; i >= stopNumber; i--)
            {
                for (int j = startNumber; j >= stopNumber; j--)
                {
                    counter++;
                    if (i + j == magicNumber)
                    {
                        Console.WriteLine("Combination N:{0} ({1} + {2} = {3})", counter, i, j, magicNumber);
                        check = true; break;
                    }                    
                }
                if (check == true) break;
            }

            if (check == false)
            {
                Console.WriteLine("{0} combinations - neither equals {1}", counter, magicNumber);
            }
        }
    }
}
