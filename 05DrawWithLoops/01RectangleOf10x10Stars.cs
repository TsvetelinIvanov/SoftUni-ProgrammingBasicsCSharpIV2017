using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01RectangleOf10x10Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            string starRow = new string('*', 10);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(starRow);
            }
        }
    }
}
