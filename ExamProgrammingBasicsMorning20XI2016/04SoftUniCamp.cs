using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04SoftUniCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());
            int carGroup = 0;
            int microbusGroup = 0;
            int busGroup = 0;
            int autobusGroup = 0;
            int trainGroup = 0;
            int allPeople = 0;

            for (int i = 0; i < groups; i++)
            {
                int people = int.Parse(Console.ReadLine());
                if (people <= 5)
                {
                    carGroup += people;
                }
                else if (people <= 12)
                {
                    microbusGroup += people;
                }
                else if (people <= 25)
                {
                    busGroup += people;
                }
                else if (people <= 40)
                {
                    autobusGroup += people;
                }
                else
                {
                    trainGroup += people;
                }
                allPeople += people;
            }

            double carPercent = carGroup * 100.0 / allPeople;
            double microbusPercent = microbusGroup * 100.0 / allPeople;
            double busPercent = busGroup * 100.0 / allPeople;
            double autobusPercent = autobusGroup * 100.0 / allPeople;
            double trainPercent = trainGroup * 100.0 / allPeople;

            Console.WriteLine("{0:f2}%", carPercent);
            Console.WriteLine("{0:f2}%", microbusPercent);
            Console.WriteLine("{0:f2}%", busPercent);
            Console.WriteLine("{0:f2}%", autobusPercent);
            Console.WriteLine("{0:f2}%", trainPercent);
        }             
    }
}
