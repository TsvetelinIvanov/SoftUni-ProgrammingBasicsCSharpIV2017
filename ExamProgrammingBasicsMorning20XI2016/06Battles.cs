using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokemonsCount1 = int.Parse(Console.ReadLine());
            int pokemonsCount2 = int.Parse(Console.ReadLine());
            int maxBattlesCount = int.Parse(Console.ReadLine());
            
            int counter = 0;
            bool areBattlesPossible = true;
            for (int p1 = 1; p1 <= pokemonsCount1; p1++)
            {
                for (int p2 = 1; p2 <= pokemonsCount2; p2++)
                {
                    Console.Write("({0} <-> {1}) ", p1, p2);
                    counter++;
                    if (counter >= maxBattlesCount)
                    {
                        areBattlesPossible = false;
                        break;
                    }
                }
                
                if (areBattlesPossible == false)
                {
                    break;
                }
            }            
        }
    }
}
