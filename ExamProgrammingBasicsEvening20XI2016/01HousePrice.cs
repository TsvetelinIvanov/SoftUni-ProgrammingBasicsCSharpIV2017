using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01HousePrice
{
    class Program
    {
        static void Main(string[] args)
        {
            double smallestRoom = double.Parse(Console.ReadLine());
            double kitchen = double.Parse(Console.ReadLine());
            double squarePrice = double.Parse(Console.ReadLine());

            double bathroom = smallestRoom / 2;
            double secondRoom = smallestRoom * 1.1;
            double thirdRoom = secondRoom * 1.1;
            double apartmentArea = smallestRoom + kitchen + bathroom + secondRoom + thirdRoom;
            double totalApartmentArea = apartmentArea + apartmentArea * 0.05;
            double apartmentPrice = squarePrice * totalApartmentArea;

            Console.WriteLine("{0:f2}", apartmentPrice);
        }
    }
}
