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
            int hours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            
            double workHours = (days - (0.1 * days)) * 8;
            int overHours = workers * (2 * days);
            double totalHours = workHours + overHours;
            double differenceHours = Math.Abs(totalHours - hours);
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
