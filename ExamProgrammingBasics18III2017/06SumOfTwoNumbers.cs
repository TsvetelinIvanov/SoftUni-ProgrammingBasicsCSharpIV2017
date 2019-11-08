using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int stoptNumber = int.Parse(Console.ReadLine());
            int magictNumber = int.Parse(Console.ReadLine());
            bool check = false;
            int counter = 0;

            for (int i = startNumber; i <= stoptNumber; i++)
            {
                for (int j = startNumber; j <= stoptNumber; j++)
                {
                    counter++;
                    if (i + j == magictNumber)
                    {
                        Console.WriteLine("Combination N:{0} ({1} + {2} = {3})", counter, i, j, magictNumber);
                        check = true;
                        break;
                    }
                }
                if (check == true) 
                break;
            }

            if (check == false)
            {
                Console.WriteLine("{0} combinations - neither equals {1}", counter, magictNumber);
            }
        }
    }
}
