using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int lenght = 2 * n + 3;

            for (int i = 1; i <= n; i++)
            {
                int asterisksCount = i;
                int dashesCount = lenght - 2 - 2 * asterisksCount;
                Console.WriteLine(@"{0}\{1}/{0}", new string('*', asterisksCount), new string('-', dashesCount));
            }
            
            int middleAsterisksCount = n;
            int sideAsterisksCount = (lenght - middleAsterisksCount - 4) / 2;
            for (int i = 0; i < n / 3; i++)
            {
                Console.WriteLine(@"|{0}\{1}/{0}|", new string('*', sideAsterisksCount), new string('*', middleAsterisksCount));
                sideAsterisksCount++;
                middleAsterisksCount -= 2;
            }
            
            for (int i = 1; i <= n; i++)
            {
                int dashesCount = i;
                int asterisksCount = lenght - 2 - 2 * dashesCount;
                Console.WriteLine(@"{0}\{1}/{0}", new string('-', dashesCount), new string('*', asterisksCount));
            }
        }
    }
}
