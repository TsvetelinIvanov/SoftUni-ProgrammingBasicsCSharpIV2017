using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysCount = int.Parse(Console.ReadLine());
            int doctorsCount = 7;
            
            int treatedPatiensCount = 0;
            int untreatedPatiensCount = 0;
            for (int i = 1; i <= daysCount; i++)
            {
                if (i % 3 == 0)
                {
                    if (treatedPatiensCount < untreatedPatiensCount)
                    {
                        doctors++;
                    }
                }
                
                int patiensCount = int.Parse(Console.ReadLine());
                if (patiensCount >= doctorsCount)
                {
                    treatedPatiensCount += doctorsCount;
                    untreatedPatiensCount += patiensCount - doctorsCount;
                }
                else
                {
                    treatedPatiensCount += patiensCount;
                }
            }

            Console.WriteLine("Treated patients: {0}.", treatedPatiensCount);
            Console.WriteLine("Untreated patients: {0}.", untreatedPatiensCount);
        }
    }
}
