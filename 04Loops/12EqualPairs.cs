using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double previousPair = 0;
            double currentPair = 0;
            double diffence = 0;
            double biggestDifference = 0;
            for (int i = 0; i < n; i++)
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());

                if (i == 0)
                {
                    previousPair = a + b;
                }
                else
                {
                    currentPair = a + b;
                    diffence = Math.Abs(currentPair - previousPair);
                    if (diffence > biggestDifference) { biggestDifference = diffence; }
                    previousPair = currentPair;
                }
            }
            
            if (biggestDifference == 0)
            {
                Console.WriteLine("Yes, value=" + previousPair);
            }
            else
            {
                Console.WriteLine("No, maxdiff=" + biggestDifference);
            }
        }
    }
}
