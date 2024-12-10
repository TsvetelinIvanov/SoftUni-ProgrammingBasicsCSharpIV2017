using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01DogHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double sides = w * (w / 2) * 2;
            
            double square = (w / 2) * (w / 2);
            double triangle = (w / 2 * (h - w / 2)) / 2;
            double back = square + triangle;
            
            double entrance = (w / 5) * (w / 5);
            double front = back - entrance;
            double green = (sides + back + front) / 3;

            double roof = w * (w / 2) * 2;
            double red = roof / 5;

            Console.WriteLine("{0:f2}", green);
            Console.WriteLine("{0:f2}", red);
        }
    }
}
