using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08TradeComissions
{
    class Program
    {
        static void Main(string[] args)
        {
            var town = Console.ReadLine().ToLower();
            double quontity = double.Parse(Console.ReadLine());
            double comission = -1.0;
            if (town == "sofia")
            {
                if (quontity >= 0 && quontity <= 500) comission = 0.05;
                else if (quontity > 500 && quontity <= 1000) comission = 0.07;
                else if (quontity > 1000 && quontity <= 10000) comission = 0.08;
                else if (quontity > 10000) comission = 0.12;
            }
            else if (town == "varna")
            {
                if (quontity >= 0 && quontity <= 500) comission = 0.045;
                else if (quontity > 500 && quontity <= 1000) comission = 0.075;
                else if (quontity > 1000 && quontity <= 10000) comission = 0.1;
                else if (quontity > 10000) comission = 0.13;
            }
            else if (town == "plovdiv")
            {
                if (quontity >= 0 && quontity <= 500) comission = 0.055;
                else if (quontity > 500 && quontity <= 1000) comission = 0.08;
                else if (quontity > 1000 && quontity <= 10000) comission = 0.12;
                else if (quontity > 10000) comission = 0.145;
            }
            
            if (comission >= 0) Console.WriteLine("{0:f2}", quontity * comission);
            else Console.WriteLine("error");
        }
    }
}
