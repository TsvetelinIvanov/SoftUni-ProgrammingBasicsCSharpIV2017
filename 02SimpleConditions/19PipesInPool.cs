using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            double V = double.Parse(Console.ReadLine());
            double P1 = double.Parse(Console.ReadLine());
            double P2 = double.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());
            
            double waterP1 = P1 * H;
            double waterP2 = P2 * H;
            double water = waterP1 + waterP2;
            if (V >= water)
            {
               double total = Math.Truncate(water / (V / 100));
               double Pp1 = Math.Truncate(waterP1 / (water / 100));
               double Pp2 = Math.Truncate(waterP2 / (water / 100));
               Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", total, Pp1, Pp2);
            }
            else
            {
               double total = water - V;
               Console.WriteLine("For {0} hours the pool overflows with {1} liters.", H, total);
            }
          }
        }
      }
