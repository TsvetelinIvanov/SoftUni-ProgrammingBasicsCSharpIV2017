using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double metersCount = double.Parse(Console.ReadLine());
            string entryMagnitude = Console.ReadLine();
            string exitMagnitude = Console.ReadLine();
            double result = 0.0;

            if (entryMagnitude == "mm")
            {
                result = metersCount / 1000;
            }
            else if (entryMagnitude == "cm")
            {
                result = metersCount / 100;
            }
            else if (entryMagnitude == "mi")
            {
                result = metersCount / 0.000621371192;
            }
            else if (entryMagnitude == "in")
            {
                result = metersCount / 39.3700787;
            }
            else if (entryMagnitude == "km")
            {
                result = metersCount / 0.001;
            }
            else if (entryMagnitude == "ft")
            {
                result = metersCount / 3.2808399;
            }
            else if (entryMagnitude == "yd")
            {
                result = metersCount / 1.0936133;
            }
            else if (entryMagnitude == "m")
            {
                result = metersCount;
            }
            
            if (exitMagnitude == "mm")
            {
                result *= 1000;
            }
            else if (exitMagnitude == "cm")
            {
                result *= 100;
            }
            else if (exitMagnitude == "mi")
            {
                result *= 0.000621371192;
            }
            else if (exitMagnitude == "in")
            {
                result *= 39.3700787;
            }
            else if (exitMagnitude == "km")
            {
                result *= 0.001;
            }
            else if (exitMagnitude == "ft")
            {
                result *= 3.2808399;
            }
            else if (exitMagnitude == "yd")
            {
                result *= 1.0936133;
            }

            Console.WriteLine(result + " " + exitMagnitude);
        }
    }
}
