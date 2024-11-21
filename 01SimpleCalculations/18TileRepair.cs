using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18TileRepair
{
    class Program
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double L = double.Parse(Console.ReadLine());
            double M = double.Parse(Console.ReadLine());
            double O = double.Parse(Console.ReadLine());

            double area = (N * N) - (M * O);
            double tile = W * L;

            double tiles = area / tile;
            double time = tiles * 0.2;

            Console.WriteLine(tiles);
            Console.WriteLine(time);
        }
    }
}
