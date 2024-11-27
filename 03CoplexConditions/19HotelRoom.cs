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
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());
                      
            double apartmentIncome = 0.0;
            double studioIncome = 0.0;

            if (month == "May" || month == "October")
            {
                apartmentIncome = nightsCount * 65;
                if (nightsCount > 14)
                {
                    apartmentIncome -= (apartmentIncome * 0.1);
                }
                
                studioIncome = nightsCount * 50;
                if (nightsCount > 14)
                {
                    studioIncome -= (studioIncome * 0.3);
                }
                else if (nightsCount > 7)
                {
                    studioIncome -= (studioIncome * 0.05);
                }
            }
            else if (month == "June" || month == "September")
            {
                apartmentIncome = nightsCount * 68.70;
                if (nightsCount > 14)
                {
                    apartmentIncome -= (apartmentIncome * 0.1);
                }
                
                studioIncome = nightsCount * 75.20;
                if (nightsCount > 14)
                {
                    studioIncome -= (studioIncome * 0.2);
                }
            }
            else if (month == "July" || month == "August")
            {
                apartmentIncome = nightsCount * 77;
                if (nightsCount > 14)
                {
                    apartmentIncome -= (apartmentIncome * 0.1);
                }
                
                studioIncome = nightsCount * 76;                                
            }
            
            Console.WriteLine("Apartment: {0:f2} lv.", apartmentIncome);
            Console.WriteLine("Studio: {0:f2} lv.", studioIncome);
        }
    }
}
