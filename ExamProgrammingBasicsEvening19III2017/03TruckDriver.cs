using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kilometerPerHour = double.Parse(Console.ReadLine());
            double salary = 0.0;

            if (kilometerPerHour <= 5000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn": salary = (kilometerPerHour * 0.75) * 4; break;
                    case "Summer": salary = (kilometerPerHour * 0.9) * 4; break;
                    case "Winter": salary = (kilometerPerHour * 1.05) * 4; break;
                }
            }
            else if (kilometerPerHour <= 10000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn": salary = (kilometerPerHour * 0.95) * 4; break;
                    case "Summer": salary = (kilometerPerHour * 1.10) * 4; break;
                    case "Winter": salary = (kilometerPerHour * 1.25) * 4; break;
                }
            }
            else 
            {
                salary = (kilometerPerHour * 1.45) * 4;
            }

            salary -= salary * 0.1;
            Console.WriteLine("{0:f2}", salary);
        }
    }
}
