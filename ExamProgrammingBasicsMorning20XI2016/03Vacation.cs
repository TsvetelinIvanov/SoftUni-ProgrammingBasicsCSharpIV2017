using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int adultsCount = int.Parse(Console.ReadLine());
            int kidsCount = int.Parse(Console.ReadLine());
            int nightsCount = int.Parse(Console.ReadLine());
            string transportKind = Console.ReadLine();
            
            double adultsTransportCost = 0.0;
            double kidsTransportCost = 0.0;
            switch (transportKind)
            {
                case "train":
                    adultsTransportCost = 24.99;
                    kidsTransportCost = 14.99; 
                    if (adultsCount + kidsCount >= 50)
                    {
                        adultsTransportCost *= 0.5;
                        kidsTransportCost *= 0.5;
                    }
                    
                    break;
                case "bus":
                    adultsTransportCost = 32.50;
                    kidsTransportCost = 28.50;
                    break;
                case "boat":
                    adultsTransportCost = 42.99;
                    kidsTransportCost = 39.99;
                    break;
                case "airplane":
                    adultsTransportCost = 70.0;
                    kidsTransportCost = 50.0;
                    break;
            }

            double transportCost = (adultsTransportCost * adultsCount + kidsTransportCost * kidsCount) * 2;
            double hotelCost = 82.99 * nightsCount;
            double commission = (transportCost + hotelCost) / 10.0;
            double totalCost = transportCost + hotelCost + commission;

            Console.WriteLine("{0:f2}", totalCost);
        }
    }
}
