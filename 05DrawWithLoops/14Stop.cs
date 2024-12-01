using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
	    int pointsCount = n;
            int middleCount = 2 * n - 1;
            Console.WriteLine("{0}{1}{0}", new string('.', n + 1), new string('_', 2 * n + 1));
            for (int i = 0; i < n; i++)
	    {
		Console.WriteLine(@"{0}//{1}\\{0}", new string('.', pointsCount), new string('_', middleCount));
                pointsCount--;
                middleCount += 2;
	    }
            
            Console.WriteLine(@"//{0}STOP!{0}\\", new string('_', middleCount / 2 - 2));
		
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(@"{0}\\{1}//{0}", new string('.', pointsCount), new string('_', middleCount));
                pointsCount++;
                middleCount -= 2;
            }
        }
    }
}
