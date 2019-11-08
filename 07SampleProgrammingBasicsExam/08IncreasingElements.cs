using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08IncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            int nextCounter = 0;
            int previousNumber = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number > previousNumber)
                {
                    counter++;
                    if (counter > nextCounter)
                    {
                        nextCounter = counter;
                    }             
                }
                else
                {                          
                        counter = 0;                    
                }
                previousNumber = number;
            }

            if (n != 0)
                nextCounter++;
                
            Console.WriteLine(nextCounter);
        }
    }
}
