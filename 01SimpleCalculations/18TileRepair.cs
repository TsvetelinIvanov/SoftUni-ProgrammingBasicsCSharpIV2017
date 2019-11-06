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
            var N = double.Parse(Console.ReadLine());
            var W = double.Parse(Console.ReadLine());
            var L = double.Parse(Console.ReadLine());
            var M = double.Parse(Console.ReadLine());
            var O = double.Parse(Console.ReadLine());

            var area = (N * N) - (M * O);
            var tile = W * L;

            var tiles = area / tile;
            var time = tiles * 0.2;

            Console.WriteLine(tiles);
            Console.WriteLine(time);
        }
    }
}
