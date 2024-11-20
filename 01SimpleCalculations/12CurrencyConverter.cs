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
            double moneyCount = double.Parse(Console.ReadLine());
            string entryCurrency = Console.ReadLine();
            string exitCurrency = Console.ReadLine();
            double result = 0.0;

            if (entryCurrency == "USD")
            {
                result = moneyCount * 1.79549;
            }
            else if (entryCurrency == "EUR")
            {
                result = moneyCount * 1.95583;
            }
            else if (entryCurrency == "GBP")
            {
                result = moneyCount * 2.53405;
            }
            else if (entryCurrency == "BGN")
            {
                result = moneyCount;
            }
            
            if (exitCurrency == "USD")
            {
                result = result / 1.79549;
            }
            else if (exitCurrency == "EUR")
            {
                result = result / 1.95583;
            }
            else if (exitCurrency == "GBP")
            {
                result = result / 2.53405;
            }
            
            Console.WriteLine(Math.Round(result, 2) + " " + exitCurrency);
        }
    }
}
