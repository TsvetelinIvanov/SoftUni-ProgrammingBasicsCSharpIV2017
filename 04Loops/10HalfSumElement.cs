using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = -1000000000;
            
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                if (num > max)
                {
                    max = num;
                }
            }
            
            if (max == (sum - max))
            {
                Console.WriteLine("Yes Sum = " + max);
            }
            else
            {
                Console.WriteLine("No Diff = " + Math.Abs(Math.Abs(sum - max) - max));
            }
        }
    }
}
