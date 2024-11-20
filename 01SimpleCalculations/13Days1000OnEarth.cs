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
            string dateString = Console.ReadLine();
            DateTime date = DateTime.ParseExact(dateString, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            date = date.AddDays(999);
            Console.WriteLine(date.ToString("dd-MM-yyyy"));
        }
    }
}
