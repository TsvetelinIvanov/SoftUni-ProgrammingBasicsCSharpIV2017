using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13Days1000OnEarth
{
    class Program
    {
        static void Main(string[] args)
        {
            string entry = Console.ReadLine();
            DateTime date = DateTime.ParseExact(entry, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            date = date.AddDays(999);
            Console.WriteLine(date.ToString("dd-MM-yyyy"));
        }
    }
}
