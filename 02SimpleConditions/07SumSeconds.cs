using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int time1 = int.Parse(Console.ReadLine());
            int time2 = int.Parse(Console.ReadLine());
            int time3 = int.Parse(Console.ReadLine());

            int timeSum = time1 + time2 + time3;
            int minutes = sumTime / 60;
            int seconds = sumTime % 60;

            Console.WriteLine(minutes + ":" + "{0:00}", seconds);
        }     
    }
}
