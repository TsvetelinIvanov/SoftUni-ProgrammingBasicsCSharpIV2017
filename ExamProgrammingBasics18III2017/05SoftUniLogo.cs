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
            int mid = 0;

            for (int i = 0; i < 2 * n; i++)
            {
                Console.WriteLine("{0}{1}#{1}{0}", new string('.', ((width - 1) / 2) - mid), new string('#', mid));
                mid += 3;
            }
            
            mid -= 6;
            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine("|{0}{1}#{1}{0}.", new string('.', ((width - 1) / 2) - mid - 1), new string('#', mid));
                mid -= 3;
            }
            
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("|{0}{1}#{1}{0}.", new string('.', ((width - 1) / 2) - mid - 1), new string('#', mid));                
            }
            
            Console.WriteLine("@{0}{1}#{1}{0}.", new string('.', ((width - 1) / 2) - mid - 1), new string('#', mid));
        }
    }
}
