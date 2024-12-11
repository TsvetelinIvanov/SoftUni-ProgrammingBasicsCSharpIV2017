using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02WorkHours
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededHoursCount = int.Parse(Console.ReadLine());
            int workersCount = int.Parse(Console.ReadLine());
            int workDaysCount = int.Parse(Console.ReadLine());

            int workHoursCount = workersCount * workDaysCount * 8;
            if (workHoursCount >= neededHoursCount)
            {
                Console.WriteLine("{0} hours left", workHoursCount - neededHoursCount);
            }
            else
            {
                Console.WriteLine("{0} overtime", neededHoursCount - workHoursCount);
                Console.WriteLine("Penalties: {0} ", (neededHoursCount - workHoursCount) * workDaysCount);
            }
        }
    }
}
