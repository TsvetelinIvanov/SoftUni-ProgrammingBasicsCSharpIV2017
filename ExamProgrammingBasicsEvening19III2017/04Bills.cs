using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int monthsCount = int.Parse(Console.ReadLine());
            
            double electricity = 0.0;
            double water = 0.0;
            double internet = 0.0;
            double other = 0.0;          
            for (int i = 1; i <= monthsCount; i++)
            {
                double electricityPerMonth = double.Parse(Console.ReadLine());
                electricity += electricityPerMonth;
                water += 20;
                internet += 15;
                other += ((electricityPerMonth + 20 + 15) + ((electricityPerMonth + 20 + 15) * 0.2));
            }

            double average = (electricity + water + internet + other) / (double)monthsCount;

            Console.WriteLine("Electricity: {0:f2} lv", electricity);
            Console.WriteLine("Water: {0:f2} lv", water);
            Console.WriteLine("Internet: {0:f2} lv", internet);
            Console.WriteLine("Other: {0:f2} lv", other);
            Console.WriteLine("Average: {0:f2} lv", average);
        }
    }
}
