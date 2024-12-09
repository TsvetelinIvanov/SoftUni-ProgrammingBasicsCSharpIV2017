using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05DateAfter5Days
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int dateDay = day + 5;
            int dateMonth = month;   
         
            if (((month == 1 || month == 01) || (month == 3 || month == 03) || (month == 5 || month == 05) 
                || (month == 7 || month == 07) || (month == 8 || month == 08) || month == 10) && dateDay > 31)
            {
                dateDay = dateDay - 31;
                dateMonth++;
            }
            else if (((month == 4 || month == 04) || (month == 6 || month == 06) || (month == 9 || month == 09)
                || month == 11) && dateDay > 30)
            {
                dateDay = dateDay - 30;
                dateMonth++;
            }
            else if ((month == 2 || month == 02) && dateDay > 28)
            {
                dateDay = dateDay - 28;
                dateMonth++;
            }
            else if (month == 12 && dateDay > 31)
            {
                dateDay = dateDay - 31;
                dateMonth = 1;
            }

            Console.WriteLine("{0}.{1:00}", dateDay, dateMonth);
        }
    }
}
