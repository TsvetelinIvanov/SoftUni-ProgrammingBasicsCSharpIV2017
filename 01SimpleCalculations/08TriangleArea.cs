using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var area1 = a * h / 2;
            var area = Math.Round(area1, 2);
            Console.WriteLine("Triangle area = " + area);
        }
    }
}
