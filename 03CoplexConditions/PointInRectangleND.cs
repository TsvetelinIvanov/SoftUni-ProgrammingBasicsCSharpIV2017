using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInRectangleND
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("The dimensions' count must be a positive number!");
            }
            else
            {
                bool checkNs = true;
                for (int i = 0; i < n; i++)
                {
                    int n1 = int.Parse(Console.ReadLine());
                    int n2 = int.Parse(Console.ReadLine());
                    int nPoint = int.Parse(Console.ReadLine());
                    if (n1 > n2)
                    {
                        Console.WriteLine("The first number cannot be greater than second number!");

                        return;
                    }
                    
                    bool checkN = (nPoint >= n1) && (nPoint <= n2);
                    if (!checkN)
                    {
                        checkNs = false;
                        break;
                    }
                }
                
                if (checkNs)
                {
                    Console.WriteLine("Inside");
                }
                else
                {
                    Console.WriteLine("Outside");
                }
            }
        }
    }
}
