using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = 1;
            for (int row = 1; row <= n; row++)
            {
                for (int column = 1; column <= row; column++)
                {
                    if (number > n) 
                    {
                        break;
                    }
                    
                    Console.Write("{0} ", number);
                    number++;                    
                }
                
                Console.WriteLine();
                if (number > n) 
                {
                    break; //for removing the spaces.
                }
            }
        }
    }
}
