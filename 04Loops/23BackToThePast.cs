using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double inheritance = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            
            double spentMoney = 0;
            int age = 18;
            for (int i = 1800; i <= year; i++)
            {
                if (i % 2 == 0)
                {
                    spentMoney += 12000;
                }
                else
                {
                    spentMoney += 12000 + 50 * age;
                }
                
                age++;
            }
            
            if (inheritance >= spentMoney)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", inheritance - spentMoney);
            }
            else
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.", spentMoney - inheritance);
            }
        }
    }
}
