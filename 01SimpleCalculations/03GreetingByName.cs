using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03GreetingByName
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter yor name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
