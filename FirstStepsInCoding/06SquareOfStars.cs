using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06SquareOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            string stars = new string('*', n);

            Console.WriteLine(stars);
            for (int i = 1; i < n - 1; i++)
            {
                Console.WriteLine("*" + new string(' ', n - 2) + "*");
            }

            Console.WriteLine(stars);
        }
    }
}
