using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysCount = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double dogFood = double.Parse(Console.ReadLine());
            double catFood = double.Parse(Console.ReadLine());
            double turtleFood = double.Parse(Console.ReadLine());

            double animalFood = dogFood * daysCount + catFood * daysCount + (turtleFood / 1000) * daysCount;            
            if (food >= animalFood)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(food - animalFood));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(animalFood - food));
            }
        }
    }
}
