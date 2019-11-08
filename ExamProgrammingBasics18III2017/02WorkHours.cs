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
            int neededHours = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int workDays = int.Parse(Console.ReadLine());

            int workHours = workers * workDays * 8;
            if (workHours >= neededHours)
            {
                Console.WriteLine("{0} hours left", workHours - neededHours);
            }
            else
            {
                Console.WriteLine("{0} overtime", neededHours - workHours);
                Console.WriteLine("Penalties: {0} ", (neededHours - workHours) * workDays);
            }
        }
    }
}
