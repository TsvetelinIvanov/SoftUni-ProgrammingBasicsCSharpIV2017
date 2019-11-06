using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20DayIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            var workday = int.Parse(Console.ReadLine());
            var moneyOnWorkday = double.Parse(Console.ReadLine());
            var USDtoBGN = double.Parse(Console.ReadLine());

            var monthIncome = workday * moneyOnWorkday;
            var yearIncome = (monthIncome * 12) + (monthIncome * 2.5);
            var tax = (yearIncome * 25) / 100;
            var disposableYearIncome = (yearIncome - tax) * USDtoBGN;
            var disposableDayIncome = disposableYearIncome / 365;

            Console.WriteLine(Math.Round(disposableDayIncome, 2));
        }
    }
}
