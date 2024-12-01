using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12Fort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write(@"/{0}\", new string('^' n / 2));
            int linesCount = 0;            
            for (int i = 5; i <= n; i += 2)
            {                    
                linesCount++;
                Console.Write("__", linesCount);
            }
            
            Console.WriteLine(@"/{0}\", new string('^', n / 2));
            
            if (n <= 4)
            {
                for (int i = 0; i < n - 2; i++)
                {
                    Console.WriteLine("|{0}|", new string(' ', (n - 1) * 2));
                }
            }
            else
            {
                for (int i = 0; i < n - 3; i++)
                {
                    Console.WriteLine("|{0}|", new string(' ', (n - 1) * 2));
                } 
                
                Console.Write("|{0}", new string(' ', n / 2 + 1));                
                for (int i = 5; i <= n; i += 2)
                {
                    linesCount++;
                    Console.Write("__", linesCount);
                }
                
                Console.WriteLine("{0}|", new string(' ', n / 2 + 1));
            }
            
            Console.Write(@"\{0}/", new string('_', n / 2));               
            for (int i = 5; i <= n; i += 2)
            {
                linesCount++;
                Console.Write("  ", linesCount);
            }
            
            Console.WriteLine(@"\{0}/", new string('_', n / 2));
        }
    }
}
