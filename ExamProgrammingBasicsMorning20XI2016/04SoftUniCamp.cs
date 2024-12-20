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
            int groupsCount = int.Parse(Console.ReadLine());
            
            int carGroup = 0;
            int microbusGroup = 0;
            int busGroup = 0;
            int autobusGroup = 0;
            int trainGroup = 0;
            int allPeopleCount = 0;
            for (int i = 0; i < groupsCount; i++)
            {
                int peopleCount = int.Parse(Console.ReadLine());
                if (peopleCount <= 5)
                {
                    carGroup += peopleCount;
                }
                else if (peopleCount <= 12)
                {
                    microbusGroup += peopleCount;
                }
                else if (peopleCount <= 25)
                {
                    busGroup += peopleCount;
                }
                else if (peopleCount <= 40)
                {
                    autobusGroup += peopleCount;
                }
                else
                {
                    trainGroup += peopleCount;
                }
                
                allPeopleCount += peopleCount;
            }

            double carPercent = carGroup * 100.0 / allPeopleCount;
            double microbusPercent = microbusGroup * 100.0 / allPeopleCount;
            double busPercent = busGroup * 100.0 / allPeopleCount;
            double autobusPercent = autobusGroup * 100.0 / allPeopleCount;
            double trainPercent = trainGroup * 100.0 / allPeopleCount;

            Console.WriteLine("{0:f2}%", carPercent);
            Console.WriteLine("{0:f2}%", microbusPercent);
            Console.WriteLine("{0:f2}%", busPercent);
            Console.WriteLine("{0:f2}%", autobusPercent);
            Console.WriteLine("{0:f2}%", trainPercent);
        }             
    }
}
