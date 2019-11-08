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
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            char oper = char.Parse(Console.ReadLine());
            double result = 0.0;
            switch (oper)
            {
                case '+': result = n1 + n2; Console.Write("{0} + {1} = {2} - ", n1, n2, result);
                    if (result % 2 == 0) { Console.WriteLine("even"); } else { Console.WriteLine("odd"); } break;
                case '-': result = n1 - n2; Console.Write("{0} - {1} = {2} - ", n1, n2, result); 
                    if (result % 2 == 0) {Console.WriteLine("even"); } else {Console.WriteLine("odd"); } break;
                case '*': result = n1 * n2; Console.Write("{0} * {1} = {2} - ", n1, n2, result); 
                    if (result % 2 == 0) {Console.WriteLine("even"); } else {Console.WriteLine("odd"); } break;                
            }
            
            if (oper == '/')
            {
                if (n2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", n1);
                }
                else
                {
                    result = n1 / n2; Console.WriteLine("{0} / {1} = {2:f2}", n1, n2, result);
                }
            }
            else if (oper == '%')
            {
                if (n2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", n1);
                }
                else
                {
                    result = n1 % n2; Console.WriteLine("{0} % {1} = {2}", n1, n2, result);
                }
            }            
        }
    }
}
