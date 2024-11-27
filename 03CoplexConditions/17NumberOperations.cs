using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17NumberOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            char sign = char.Parse(Console.ReadLine());
            double result = 0.0;
            switch (sign)
            {
                case '+':
                    result = number1 + number2;
                    Console.Write("{0} + {1} = {2} - ", number1, number2, result);
                    if (result % 2 == 0)
                    {
                        Console.WriteLine("even"); 
                    }
                    else
                    {
                        Console.WriteLine("odd");
                    }
                    
                    break;
                case '-':
                    result = number1 - number2;
                    Console.Write("{0} - {1} = {2} - ", number1, number2, result); 
                    if (result % 2 == 0)
                    {
                        Console.WriteLine("even");
                    }
                    else
                    {
                        Console.WriteLine("odd");
                    }
                    
                    break;
                case '*':
                    result = number1 * number2;
                    Console.Write("{0} * {1} = {2} - ", number1, number2, result); 
                    if (result % 2 == 0)
                    {
                        Console.WriteLine("even");
                    }
                    else
                    {
                        Console.WriteLine("odd");
                    }
                    
                    break;                
            }
            
            if (sign == '/')
            {
                if (number2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", number1);
                }
                else
                {
                    result = number1 / number2;
                    Console.WriteLine("{0} / {1} = {2:f2}", number1, number2, result);
                }
            }
            else if (sign == '%')
            {
                if (number2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", number1);
                }
                else
                {
                    result = number1 % number2;
                    Console.WriteLine("{0} % {1} = {2}", n1, n2, result);
                }
            }            
        }
    }
}
