using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09PerfectDiamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
			      {
                Console.Write(new string(' ', n - 1 - i));
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*-");
                }
                Console.WriteLine("*");
			      }            

            for (int i = n - 2; i >= 0; i--)
            {
                Console.Write(new string(' ', n - 1 - i));
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*-");
                }
                Console.WriteLine("*");
            }
        }
    }
}
