using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int loadsCount = int.Parse(Console.ReadLine());
            
            int busLoadsWeight = 0;
            int lorryLoadsWeight = 0;
            int trainLoadsWeight = 0;
            int allLoadsWeight = 0;
            for (int i = 0; i < loadsCount; i++)
            {
                int loadWeight = int.Parse(Console.ReadLine());
                if (loadWeight <= 3)
                {
                    busLoadsWeight += loadWeight;
                }
                else if (loadWeight <= 11)
                {
                    lorryLoadsWeight += loadWeight;
                }
                else
                {
                    trainLoadsWeight += loadWeight;
                }
                
                allLoadsWeight += loadWeight;
            }

            double busPercent = busLoadsWeight * 100.0 / allLoadsWeight;
            double lorryPercent = lorryLoadsWeight * 100.0 / allLoadsWeight;
            double trainPercent = trainLoadsWeight * 100.0 / allLoadsWeight;
            double average = (busLoadsWeight * 200.0 + lorryLoadsWeight * 175.0 + trainLoadsWeight * 120.0) / allLoadsWeight;

            Console.WriteLine("{0:f2}", average);
            Console.WriteLine("{0:f2}%", busPercent);
            Console.WriteLine("{0:f2}%", lorryPercent);
            Console.WriteLine("{0:f2}%", trainPercent);
        }
    }
}
