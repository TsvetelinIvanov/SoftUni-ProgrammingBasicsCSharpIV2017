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
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            
            double area = a * h / 2;
            double roundedArea = Math.Round(area, 2);
            
            Console.WriteLine("Triangle area = " + roundedArea);
        }
    }
}
