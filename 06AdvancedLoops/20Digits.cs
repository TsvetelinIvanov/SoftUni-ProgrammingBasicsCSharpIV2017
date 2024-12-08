using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int abc = int.Parse(Console.ReadLine());
            int a = abc / 100;
            int b = (abc / 10) % 10;
            int c = abc % 10;
            int number = abc;
            for (int row = 0; row < a + b; row++)
            {
                for (int column = 0; column < a + c; column++)
                {
                    if (number % 5 == 0)
                    {
                        number -= a;
                    }
                    else if (number % 3 == 0)
                    {
                        number -= b;
                    }
                    else
                    {
                        number += c;
                    }
                    
                    Console.Write(number + " ");
                }
                
                Console.WriteLine();
            }
        }
    }
}
