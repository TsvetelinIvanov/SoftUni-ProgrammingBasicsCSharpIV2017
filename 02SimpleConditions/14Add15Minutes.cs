using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14Add15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());
            int futureMinute = minute + 15;
            if (futureMinute > 59)
            {
                hour += 1;
                futureMinute -= 60;
            }
            if (hour > 23)
            {
                hour = 0;
            }
            Console.WriteLine(hour + ":" + "{0:00}", futureMinute);
        }
    }
}
