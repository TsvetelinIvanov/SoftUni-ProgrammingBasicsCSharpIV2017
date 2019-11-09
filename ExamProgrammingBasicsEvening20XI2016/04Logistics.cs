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
            int loads = int.Parse(Console.ReadLine());
            int busLoads = 0;
            int lorryLoads = 0;
            int trainLoads = 0;
            int allLoads = 0;

            for (int i = 0; i < loads; i++)
            {
                int loadWeight = int.Parse(Console.ReadLine());
                if (loadWeight <= 3)
                {
                    busLoads += loadWeight;
                }
                else if (loadWeight <= 11)
                {
                    lorryLoads += loadWeight;
                }
                else
                {
                    trainLoads += loadWeight;
                }
                allLoads += loadWeight;
            }

            double busPercent = busLoads * 100.0 / allLoads;
            double lorryPercent = lorryLoads * 100.0 / allLoads;
            double trainPercent = trainLoads * 100.0 / allLoads;
            double average = (busLoads * 200.0 + lorryLoads * 175.0 + trainLoads * 120.0) / allLoads;

            Console.WriteLine("{0:f2}", average);
            Console.WriteLine("{0:f2}%", busPercent);
            Console.WriteLine("{0:f2}%", lorryPercent);
            Console.WriteLine("{0:f2}%", trainPercent);
        }
    }
}
