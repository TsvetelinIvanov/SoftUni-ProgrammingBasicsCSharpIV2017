using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20SleepingCatTom
{
    class Program
    {
        static void Main(string[] args)
        {
            int holiday = int.Parse(Console.ReadLine());
            var holidayPlay = holiday * 127;
            var workdayPlay = (365 - holiday) * 63;
            var play = holidayPlay + workdayPlay;
            int toPlay = Math.Abs(play - 30000);
            int hours = toPlay / 60;
            int minutes = toPlay % 60;
            if (play <= 30000)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, minutes);
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, minutes);
            }
        }
    }
}
