using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            var workHours = (days - (0.1 * days)) * 8;
            var overHours = workers * (2 * days);
            var totalHours = workHours + overHours;
            var differenceHours = Math.Abs(totalHours - hours);
            if (totalHours >= hours)
            {
                Console.WriteLine("Yes!{0} hours left.", Math.Floor(differenceHours));
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", Math.Ceiling(differenceHours));
            }
        }
    }
}
