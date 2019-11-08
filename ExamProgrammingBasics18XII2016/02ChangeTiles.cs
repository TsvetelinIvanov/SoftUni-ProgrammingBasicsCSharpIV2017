using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02ChangeTiles
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double floorWidth = double.Parse(Console.ReadLine());
            double floorLenght = double.Parse(Console.ReadLine());
            double triangleSide = double.Parse(Console.ReadLine());
            double triangleHeight = double.Parse(Console.ReadLine());
            double tilePrice = double.Parse(Console.ReadLine());
            double masterCost = double.Parse(Console.ReadLine());

            double floorArea = floorWidth * floorLenght;
            double tileArea = triangleSide * triangleHeight / 2;
            double tiles = Math.Ceiling(floorArea / tileArea) + 5;
            double cost = tiles * tilePrice + masterCost;

            if (money >= cost)
            {
                Console.WriteLine("{0:f2} lv left.", money - cost);
            }
            else 
            {
                Console.WriteLine("You'll need {0:f2} lv more.", cost - money);
            }
        }
    }
}
