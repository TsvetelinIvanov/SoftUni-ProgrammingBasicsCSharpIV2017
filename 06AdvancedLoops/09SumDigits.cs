using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            do 
            {
                int n1 = n % 10;
                sum = sum + n1;
                n = n / 10;
            } while (n > 0);
            
            Console.WriteLine(sum);
        }
    }
}
