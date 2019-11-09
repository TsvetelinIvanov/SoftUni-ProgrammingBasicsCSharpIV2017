using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_SumOrProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            int ctrl = int.Parse(Console.ReadLine());
            bool isNo = true;

            for (int i = 1; i <= 30; i++)
                for (int j = 1; j <= 30; j++)
                    for (int k = 1; k <= 30; k++)
                    {
                        if (i < j && j < k && i < k && i + j + k == ctrl)
                        { 
Console.WriteLine("{0} + {1} + {2} = {3}", i, j, k, ctrl); isNo = false; }
                        if (i > j && j > k && i > k && i * j * k == ctrl)
                        { 
Console.WriteLine("{0} * {1} * {2} = {3}", i, j, k, ctrl); isNo = false; }
                    }

            if (isNo == true) Console.WriteLine("No!");
        }
    }
}
