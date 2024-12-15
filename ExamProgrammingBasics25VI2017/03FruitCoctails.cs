using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03FruitCoctails
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string volume = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            
            double price = 0.0;
            double cost = 0.0;
            switch (fruit)
            {
                case "Watermelon":
                {
                    switch (volume)
                    {
                        case "small":
                            price = 2.0 * 56;
                            break;
                        case "big":
                            price = 5.0 * 28.7;
                            break;
                    }
                }
                    
                break;
                case "Mango":
                {
                    switch (volume)
                    {
                        case "small":
                            price = 2.0 * 36.66;
                            break;
                        case "big":
                            price = 5.0 * 19.6;
                            break;
                    }
                }
                    
                break;
                case "Pineapple":
                {
                    switch (volume)
                    {
                        case "small":
                            price = 2.0 * 42.1;
                            break;
                        case "big":
                            price = 5.0 * 24.8;
                            break;
                    }
                }
                    
                break;
                case "Raspberry":
                {
                    switch (volume)
                    {
                        case "small":
                            price = 2.0 * 20;
                            break;
                        case "big":
                            price = 5.0 * 15.2;
                            break;
                    }
                }
                    
                break;
            }

            cost = (double)number * price;
            if (cost > 1000)
            {
                cost = cost * 0.5;
            }
            else if (cost >= 400)
            {
                cost = cost * 0.85;
            }

            Console.WriteLine("{0:f2} lv.", cost);
        }
    }
}
