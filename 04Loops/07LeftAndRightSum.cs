using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int leftSum = 0;            
            for (int i = 0; i < n; i++)
            {
                leftSum = leftSum + int.Parse(Console.ReadLine());
            }
            
            int rightSum = 0;
            for (int i  = 0; i < n; i++)
            {
                rightSum = rightSum + int.Parse(Console.ReadLine());
            }
            
            if (rightSum == leftSum)
            {
                Console.WriteLine("Yes, sum = " + leftSum);
            }
            
            if (rightSum != leftSum)
            {
                Console.WriteLine("No, diff = " + Math.Abs(leftSum - rightSum));
            }
        }
    }
}
