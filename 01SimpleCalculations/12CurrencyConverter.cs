using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var moneyCount = double.Parse(Console.ReadLine());
            var entryValue = Console.ReadLine();
            var exitValue = Console.ReadLine();
            var answer = 0.0;

            if (entryValue == "USD")
            {
                answer = moneyCount * 1.79549;
            }
            else if (entryValue == "EUR")
            {
                answer = moneyCount * 1.95583;
            }
            else if (entryValue == "GBP")
            {
                answer = moneyCount * 2.53405;
            }
            else if (entryValue == "BGN")
            {
                answer = moneyCount;
            }
            if (exitValue == "USD")
            {
                answer = answer / 1.79549;
            }
            else if (exitValue == "EUR")
            {
                answer = answer / 1.95583;
            }
            else if (exitValue == "GBP")
            {
                answer /= 2.53405;
            }
            Console.WriteLine(Math.Round(answer, 2) + " " + exitValue);
        }
    }
}
