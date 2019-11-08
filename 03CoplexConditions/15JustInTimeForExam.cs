using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15JustInTimeForExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());

            int examTime = examHour * 60 + examMinute;
            int arrivalTime = arrivalHour * 60 + arrivalMinute;
            int differenceTime = arrivalTime - examTime;

            if (differenceTime < -30) Console.WriteLine("Early");
            else if (differenceTime <= 0) Console.WriteLine("On time");
            else Console.WriteLine("Late");

            if (differenceTime != 0)
            {
                int hour = Math.Abs(differenceTime / 60);
                int minute = Math.Abs(differenceTime % 60);

                if (hour > 0)
                {
                    if (minute < 10) Console.Write(hour + ":0" + minute + " hours");
                    else Console.Write(hour + ":" + minute + " hours");
                }
                else Console.Write(minute + " minutes");

                if (differenceTime < 0) Console.WriteLine(" before the start");
                else Console.WriteLine(" after the start");
            }
        }
    }
}
