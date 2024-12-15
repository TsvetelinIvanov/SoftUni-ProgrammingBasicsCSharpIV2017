using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int campaignDaysCount = int.Parse(Console.ReadLine());
            int confectionersCount = int.Parse(Console.ReadLine());
            int cacesCount = int.Parse(Console.ReadLine());
            int gofretiesCount = int.Parse(Console.ReadLine());
            int pancacesCount = int.Parse(Console.ReadLine());

            double cacesPrice = 45.0 * cacesCount;
            double gofretiesPrice = 5.8 * gofretiesCount;
            double pancacesPrice = 3.2 * pancacesCount;

            double dayIncome = (cacesPrice + gofretisPrice + pancacesPrice) * confectionersCount;
            double sum = (campaignDaysCount * dayIncome) - ((campaignDaysCount * dayIncome) / 8.0);
            
            Console.WriteLine("{0:f2}", sum);
        }
    }
}
