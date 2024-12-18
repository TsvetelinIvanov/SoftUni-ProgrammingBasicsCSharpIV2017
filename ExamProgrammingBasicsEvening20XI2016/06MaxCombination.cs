using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06MaxCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int maxCombination = int.Parse(Console.ReadLine());
            
            int counter = 0;
            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    Console.Write("<{0}-{1}>", i, j);
                    counter++;
                    if (counter >= maxCombination)
                    {
                        break;
                    }
                }
                
                if (counter >= maxCombination)
                {
                    break;
                }
            }
        }
    }
}
