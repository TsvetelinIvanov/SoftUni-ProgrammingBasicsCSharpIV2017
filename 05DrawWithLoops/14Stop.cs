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
            
            Console.WriteLine("{0}{1}{0}", new string('.', n + 1), new string('_', 2 * n + 1));
            
            int point = n;
            int mid = 2 * n - 1;
            for (int i = 0; i < n; i++)
			      {
			          Console.WriteLine(@"{0}//{1}\\{0}", new string('.', point), new string('_', mid));
                point--;
                mid += 2;
			      }
            
            Console.WriteLine(@"//{0}STOP!{0}\\", new string('_', mid / 2 - 2));
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(@"{0}\\{1}//{0}", new string('.', point), new string('_', mid));
                point++;
                mid -= 2;
            }
        }
    }
}
