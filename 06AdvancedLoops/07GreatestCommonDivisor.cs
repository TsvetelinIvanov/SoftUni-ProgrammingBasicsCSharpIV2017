using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07GreatestCommonDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            
            int larger = Math.Max(a, b);
            int smaller = Math.Min(a, b);            
            while (smaller != 0)
            {
                int temp = smaller;
                smaller = larger % smaller;
                larger = temp;
            }
            
            Console.WriteLine(larger);
        }
    }
}
