using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16Number1_100ToText
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int firstDigit = number / 10;
            int secondDigit = number % 10;
            int bothDigits = number;

            string firstWord = "";
            string secondWord = "";
            string bothWords = "";

            switch (secondDigit)
            {
                case 0: secondWord = "zero"; break;
                case 1: secondWord = "one"; break;
                case 2: secondWord = "two"; break;
                case 3: secondWord = "three"; break;
                case 4: secondWord = "four"; break;
                case 5: secondWord = "five"; break;
                case 6: secondWord = "six"; break;
                case 7: secondWord = "seven"; break;
                case 8: secondWord = "eight"; break;
                case 9: secondWord = "nine"; break;
                default: break;
            }
            
            switch (firstDigit)
            {
                case 2: firstWord = "twenty"; break;
                case 3: firstWord = "thirty"; break;
                case 4: firstWord = "forty"; break;
                case 5: firstWord = "fifty"; break;
                case 6: firstWord = "sixty"; break;
                case 7: firstWord = "seventy"; break;
                case 8: firstWord = "eighty"; break;
                case 9: firstWord = "ninety"; break;
                default: break;
            }
            
            switch (bothDigits)
            {
                case 10: bothWords = "ten"; break;
                case 11: bothWords = "eleven"; break;
                case 12: bothWords = "twelve"; break;
                case 13: bothWords = "thirteen"; break;
                case 14: bothWords = "fourteen"; break;
                case 15: bothWords = "fifteen"; break;
                case 16: bothWords = "sixteen"; break;
                case 17: bothWords = "seventeen"; break;
                case 18: bothWords = "eighteen"; break;
                case 19: bothWords = "nineteen"; break;
                default: break;
            }
            
            if (number >= 0 && number <= 9)
            {
                Console.WriteLine(secondWord);
            }
            else if (number >= 10 && number <= 19)
            {
                Console.WriteLine(bothWords);
            }
            else if (number >=20 && number <= 100)
            {
                if (number % 10 == 0 && number != 10 && number != 100)
                {
                    Console.WriteLine(firstWord);
                }
                else if (number == 100)
                {
                    Console.WriteLine("one hundred");
                }
                else
                {
                    Console.WriteLine(firstWord + " " + secondWord);
                }
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}
