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
            int pokemons1 = int.Parse(Console.ReadLine());
            int pokemons2 = int.Parse(Console.ReadLine());
            int maxBattles = int.Parse(Console.ReadLine());
            int counter = 0;
            bool battles = true;

            for (int p1 = 1; p1 <= pokemons1; p1++)
            {
                for (int p2 = 1; p2 <= pokemons2; p2++)
                {
                    Console.Write("({0} <-> {1}) ", p1, p2);
                    counter++;
                    if (counter >= maxBattles)
                    {
                        battles = false;
                        break;
                    }
                }
                if (battles == false) 
                    break;
            }            
        }
    }
}
