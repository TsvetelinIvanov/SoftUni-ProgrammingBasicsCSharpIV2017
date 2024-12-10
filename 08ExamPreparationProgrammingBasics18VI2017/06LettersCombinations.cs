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
            char skipLetter = char.Parse(Console.ReadLine());
            int counter = 0;
            for (char firstLetter = startLetter; firstLetter <= stoptLetter; firstLetter++)
            {
                for (char secondLetter = startLetter; secondLetter <= stoptLetter; secondLetter++)
                {
                    for (char thirdLetter = startLetter; thirdLetter <= stoptLetter; thirdLetter++)
                    {
                        if (firstLetter != skipLetter && secondLetter != skipLetter && thirdLetter != skipLetter) 
                        {
                            Console.Write("{0}{1}{2} ", firstLetter, secondLetter, thirdLetter);
                            counter++;
                        }
                    }
                }
            }
            
            Console.WriteLine(counter);
        }
    }
}
