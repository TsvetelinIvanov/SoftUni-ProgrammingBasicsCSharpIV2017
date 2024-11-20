using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16SchoolHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double h = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());

            double row = Math.Floor(h / 1.2);
            double bureau = Math.Floor((w  - 1) / 0.7);

            double place = row * bureau - 3;

            Console.WriteLine(place);
        }
    }
}
