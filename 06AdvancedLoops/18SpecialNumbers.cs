using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int n1 = 1; n1 < 10; n1++)
            {
                for (int n2 = 1; n2 < 10; n2++)
                {
                    for (int n3 = 1; n3 < 10; n3++)
                    {
                        for (int n4 = 1; n4 < 10; n4++)
                        {
                            if ((n % n1 == 0) && (n % n2 == 0) && (n % n3 == 0) && (n % n4 == 0))
                            {
                                Console.Write("{0}{1}{2}{3} ", n1, n2, n3, n4);
                            }
                        }
                    }
                }
            }
        }
    }
}
