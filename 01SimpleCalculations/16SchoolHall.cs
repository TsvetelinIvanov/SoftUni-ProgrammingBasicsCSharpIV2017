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
            var h = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());

            var row = Math.Floor((h / 1.2));
            var bureau = Math.Floor((w  - 1) / 0.7);

            var place = row * bureau - 3;

            Console.WriteLine(place);
        }
    }
}
