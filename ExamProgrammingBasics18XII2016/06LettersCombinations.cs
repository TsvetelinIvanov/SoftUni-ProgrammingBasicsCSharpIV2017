using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06LettersCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char startLetter = char.Parse(Console.ReadLine());
            char stoptLetter = char.Parse(Console.ReadLine());
            char skiptLetter = char.Parse(Console.ReadLine());
            int counter = 0;

            for (char firstLetter = startLetter; firstLetter <= stoptLetter; firstLetter++)
            {
                for (char secondLettr = startLetter; secondLettr <= stoptLetter; secondLettr++)
                {
                    for (char thirthLettr = startLetter; thirthLettr <= stoptLetter; thirthLettr++)
                    {
                        if (firstLetter != skiptLetter && secondLettr != skiptLetter && thirthLettr != skiptLetter)
                        {
                            Console.Write("{0}{1}{2} ", firstLetter, secondLettr, thirthLettr);
                            counter++;
                        }
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
