using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write("+ ");
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write("- ");
            }
            
            Console.WriteLine("+");
            
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write("| ");
                for (int j = 1; j <= n - 2; j++)
                {
                    Console.Write("- ");
                }
                
                Console.WriteLine("|");
            }
            
            Console.Write("+ ");
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write("- ");
            }

            Console.WriteLine("+");
        }
    }
}
