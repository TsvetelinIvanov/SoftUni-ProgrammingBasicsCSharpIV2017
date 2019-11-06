using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = double.Parse(Console.ReadLine());
            var f = Math.Round((c * 1.8 + 32), 2);
            Console.WriteLine(f);
        }
    }
}
