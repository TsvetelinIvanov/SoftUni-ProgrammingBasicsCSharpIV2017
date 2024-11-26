using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double weekend = (48 - h) * (3.0 / 4) + h;
            double holiday = p * (2.0 / 3);
            double volleyballPlays = holiday + weekend;
            if (year == "leap")
            {
                volleyballPlays += (volleyballPlays * 0.15);
            }
            
            Console.WriteLine(Math.Truncate(volleyballPlays));
        }
    }
}
