using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18MathTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            var category = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());
            var ticketCategory = 0.0;
            var transport = 0.0;
            var ticketMoney = 0.0;
            var ticketPeople = 0.0;
            var money = 0.0;
            if (category == "VIP")
            {
                ticketCategory = 499.99;
                if (people >= 1 && people <= 4) { transport = budget * 0.75; }
                else if (people >= 5 && people <= 9) { transport = budget * 0.60; }
                else if (people >= 10 && people <= 24) { transport = budget * 0.50; }
                else if (people >= 25 && people <= 49) { transport = budget * 0.40; }
                else if (people >= 50) { transport = budget * 0.25; }
                ticketMoney = budget - transport;
                ticketPeople = people * ticketCategory;
                money = Math.Abs(ticketMoney - ticketPeople);
            }
            else if (category == "Normal")
            {
                ticketCategory = 249.99;
                if (people >= 1 && people <= 4) { transport = budget * 0.75; }
                else if (people >= 5 && people <= 9) { transport = budget * 0.60; }
                else if (people >= 10 && people <= 24) { transport = budget * 0.50; }
                else if (people >= 25 && people <= 49) { transport = budget * 0.40; }
                else if (people >= 50) { transport = budget * 0.25; }
                ticketMoney = budget - transport;
                ticketPeople = people * ticketCategory;
                money = Math.Abs(ticketMoney - ticketPeople);
            }
            
            if (ticketMoney >= ticketPeople)
            {
                Console.WriteLine("Yes! You have {0:f2} leva left.", money);
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0:f2} leva.", money);
            }
        }
    }
}
