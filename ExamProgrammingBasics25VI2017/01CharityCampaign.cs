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
            int campaignDays = int.Parse(Console.ReadLine());
            int confectioners = int.Parse(Console.ReadLine());
            int caces = int.Parse(Console.ReadLine());
            int gofretys = int.Parse(Console.ReadLine());
            int pancaces = int.Parse(Console.ReadLine());

            double cacesPrice = 45.0 * caces;
            double gofretisPrice = 5.8 * gofretys;
            double pancacesPrice = 3.2 * pancaces;

            double daysIncome = (cacesPrice + gofretisPrice + pancacesPrice) * confectioners;
            double sum = (campaignDays * daysIncome) - ((campaignDays * daysIncome) / 8.0);

            Console.WriteLine("{0:f2}", sum);
        }
    }
}
