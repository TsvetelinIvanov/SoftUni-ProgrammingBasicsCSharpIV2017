using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08EvenOrOddSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());           
            int oddSum = 0;
            int evenSum = 0;
            
            for (int i = 0; i < n; i++)
            {     
                int currentNumber = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    oddSum += currentNumber;
                }
                else
                {
                    evenSum += currentNumber; 
                }      
            }
            
            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + evenSum);

            }
            
            if (evenSum != oddSum)
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(evenSum - oddSum));
            }
        }
    }
}
