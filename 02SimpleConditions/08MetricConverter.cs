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
            var meterCount = double.Parse(Console.ReadLine());
            var entryValue = Console.ReadLine();
            var exitValue = Console.ReadLine();
            var answer = 0.0;

            if (entryValue == "mm")
            {
                answer = meterCount / 1000;
            }
            else if (entryValue == "cm")
            {
                answer = meterCount / 100;
            }
            else if (entryValue == "mi")
            {
                answer = meterCount / 0.000621371192;
            }
            else if (entryValue == "in")
            {
                answer = meterCount / 39.3700787;
            }
            else if (entryValue == "km")
            {
                answer = meterCount / 0.001;
            }
            else if (entryValue == "ft")
            {
                answer = meterCount / 3.2808399;
            }
            else if (entryValue == "yd")
            {
                answer = meterCount / 1.0936133;
            }
            else if (entryValue == "m")
            {
                answer = meterCount;
            }
            
            if (exitValue == "mm")
            {
                answer *= 1000;
            }
            else if (exitValue == "cm")
            {
                answer *= 100;
            }
            else if (exitValue == "mi")
            {
                answer *= 0.000621371192;
            }
            else if (exitValue == "in")
            {
                answer *= 39.3700787;
            }
            else if (exitValue == "km")
            {
                answer *= 0.001;
            }
            else if (exitValue == "ft")
            {
                answer *= 3.2808399;
            }
            else if (exitValue == "yd")
            {
                answer *= 1.0936133;
            }

            Console.WriteLine(answer + " " + exitValue);
        }
    }
}
