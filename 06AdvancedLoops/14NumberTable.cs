using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14NumberTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = 0;
            for (int row = 0; row < n; row++)
            {
                for (int column = 0; column < n; column++)
                {
                    number = row + column + 1;
                    if (number >= n)
                    {
                        number = 2 * n - number;
                    }
                    
                    Console.Write("{0} ", number);
                }
                
                Console.WriteLine();
            }
        }
    }
}
