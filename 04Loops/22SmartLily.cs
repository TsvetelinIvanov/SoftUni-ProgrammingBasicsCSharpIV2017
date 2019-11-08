using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22SmartLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMashinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            double toyCount = 0;
            double birthdayMoney = 0;
            double birthdayMoneySum = 0;
            double money = 0;
            
            for (int i = 1; i <= age; i++)
            {                
                if (i % 2 == 0)
                {
                    birthdayMoney = (i * 10.0 / 2.0) - 1.0;
                    birthdayMoneySum += birtdayMoney;
                }
                else
                {
                    toyCount++;
                }
            }
            
            money = birthdayMoneySum + (toyCount * toyPrice);
            if (money >= washingMashinePrice)
            {
                Console.WriteLine("Yes! {0:f2}", money - washingMashinePrice);
            }
            else
            {
                Console.WriteLine("No! {0:f2}", washingMashinePrice - money);
            }
        }
    }
}
