using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            int night = int.Parse(Console.ReadLine());
                      
            double apartment = 0.0;
            double studio = 0.0;

            if (month == "May" || month == "October")
            {
                apartment = night * 65;
                if (night > 14) { apartment -= (apartment * 0.1); }
                studio = night * 50;
                if (night > 14) { studio -= (studio * 0.3); }
                else if (night > 7) { studio -= (studio * 0.05); }
            }
            else if (month == "June" || month == "September")
            {
                apartment = night * 68.70;
                if (night > 14) { apartment -= (apartment * 0.1); }
                studio = night * 75.20;
                if (night > 14) { studio -= (studio * 0.2); }
            }
            else if (month == "July" || month == "August")
            {
                apartment = night * 77;
                if (night > 14) { apartment -= (apartment * 0.1); }
                studio = night * 76;                                
            }
            
            Console.WriteLine("Apartment: {0:f2} lv.", apartment);
            Console.WriteLine("Studio: {0:f2} lv.", studio);
        }
    }
}
