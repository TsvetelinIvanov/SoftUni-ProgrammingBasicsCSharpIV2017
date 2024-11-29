using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                int curentNumber = int.Parse(Console.ReadLine());
                if (curentNumber > max)
                {
                    max = curentNumber;
                }                
            }
            
            Console.WriteLine("max = " + max);
        }
    }
}
