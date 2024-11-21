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
            int workdaysCount = int.Parse(Console.ReadLine());
            double moneyPerWorkday = double.Parse(Console.ReadLine());
            double USDtoBGN = double.Parse(Console.ReadLine());

            double monthIncome = workdaysCount * moneyPerWorkday;
            double yearIncome = (monthIncome * 12) + (monthIncome * 2.5);
            double tax = (yearIncome * 25) / 100;
            double disposableYearIncome = (yearIncome - tax) * USDtoBGN;
            double disposableDayIncome = disposableYearIncome / 365;

            Console.WriteLine(Math.Round(disposableDayIncome, 2));
        }
    }
}
