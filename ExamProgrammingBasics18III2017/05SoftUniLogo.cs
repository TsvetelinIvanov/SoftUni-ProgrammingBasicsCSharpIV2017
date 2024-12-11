using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05SoftUniLogo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int width = 12 * n - 5;
            int height = 4 * n - 2;
            int middle = 0;
            for (int i = 0; i < 2 * n; i++)
            {
                Console.WriteLine("{0}{1}#{1}{0}", new string('.', ((width - 1) / 2) - middle), new string('#', middle));
                middle += 3;
            }
            
            middle -= 6;
            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine("|{0}{1}#{1}{0}.", new string('.', ((width - 1) / 2) - middle - 1), new string('#', middle));
                middle -= 3;
            }
            
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("|{0}{1}#{1}{0}.", new string('.', ((width - 1) / 2) - middle - 1), new string('#', middle));                
            }
            
            Console.WriteLine("@{0}{1}#{1}{0}.", new string('.', ((width - 1) / 2) - middle - 1), new string('#', middle));
        }
    }
}
