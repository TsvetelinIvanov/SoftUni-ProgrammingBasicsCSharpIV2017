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
            string category = Console.ReadLine();
            int peopleCount = int.Parse(Console.ReadLine());
            
            double ticketCategory = 0.0;
            double transportCost = 0.0;
            double moneyForTickets = 0.0;
            double ticketsCost = 0.0;
            double money = 0.0;
            
            if (category == "VIP")
            {
                ticketCategory = 499.99;
                if (peopleCount >= 1 && peopleCount <= 4)
                {
                    transportCost = budget * 0.75;
                }
                else if (peopleCount >= 5 && peopleCount <= 9)
                {
                    transportCost = budget * 0.60;
                }
                else if (peopleCount >= 10 && peopleCount <= 24)
                {
                    transportCost = budget * 0.50;
                }
                else if (peopleCount >= 25 && peopleCount <= 49)
                {
                    transportCost = budget * 0.40;
                }
                else if (peopleCount >= 50)
                {
                    transportCost = budget * 0.25;
                }
                
                moneyForTickets = budget - transportCost;
                ticketsCost = peopleCount * ticketCategory;
                money = Math.Abs(moneyForTickets - ticketsCost);
            }
            else if (category == "Normal")
            {
                ticketCategory = 249.99;
                if (peopleCount >= 1 && peopleCount <= 4)
                {
                    transportCost = budget * 0.75;
                }
                else if (peopleCount >= 5 && peopleCount <= 9)
                {
                    transportCost = budget * 0.60;
                }
                else if (peopleCount >= 10 && peopleCount <= 24)
                {
                    transportCost = budget * 0.50;
                }
                else if (peopleCount >= 25 && peopleCount <= 49)
                {
                    transportCost = budget * 0.40;
                }
                else if (peopleCount >= 50) 
                {
                    transportCost = budget * 0.25;
                }
                
                moneyForTickets = budget - transportCost;
                ticketsCost = peopleCount * ticketCategory;
                money = Math.Abs(moneyForTickets - ticketsCost);
            }
            
            if (moneyForTickets >= ticketsCost)
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
