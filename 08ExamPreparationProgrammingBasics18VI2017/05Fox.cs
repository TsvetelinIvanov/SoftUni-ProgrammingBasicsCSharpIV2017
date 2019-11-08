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
                int asterics = i;
                int dashes = lenght - 2 - 2 * asterics;
                Console.WriteLine(@"{0}\{1}/{0}", new string('*', asterics), new string('-', dashes));
	          }

            int midleAsterics = n;
            int sideAsterics = (lenght - midleAsterics - 4) / 2;
            for (int i = 0; i < n / 3; i++)
	          {                
                Console.WriteLine(@"|{0}\{1}/{0}|", new string('*', sideAsterics), new string('*', midleAsterics));
                sideAsterics++;
                midleAsterics -= 2;
	          }

            for (int i = 1; i <= n; i++)
            {
                int asterics = i;
                int dashes = lenght - 2 - 2 * asterics;
                Console.WriteLine(@"{0}\{1}/{0}", new string('-', asterics), new string('*', dashes));
            }
        }
    }
}
