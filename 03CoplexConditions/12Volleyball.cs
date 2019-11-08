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
            var year = Console.ReadLine();
            var p = int.Parse(Console.ReadLine());
            var h = int.Parse(Console.ReadLine());
            var weekend = (48 - h) * (3.0 / 4) + h;
            var holiday = p * (2.0 / 3);
            var volleyballPlays = holiday + weekend;
            if (year == "leap") volleyballPlays += (volleyballPlays * 0.15);
            Console.WriteLine(Math.Truncate(volleyballPlays));
        }
    }
}
