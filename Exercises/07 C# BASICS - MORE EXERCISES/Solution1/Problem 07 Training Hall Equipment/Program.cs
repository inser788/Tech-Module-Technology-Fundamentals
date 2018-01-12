using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_07_Training_Hall_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfItems = int.Parse(Console.ReadLine());

            double priceTotal = 0.0;

            for (int i = 1; i <= numberOfItems; i++)
            {
                string itemName = Console.ReadLine();
                double itemPrice = double.Parse(Console.ReadLine());
                int itemCount = int.Parse(Console.ReadLine());
                priceTotal += itemCount * itemPrice;

                if (itemCount>1)
                {
                    Console.WriteLine($"Adding {itemCount} {itemName}s to cart.");
                }
                else if(itemCount==1)
                {
                    Console.WriteLine($"Adding {itemCount} {itemName} to cart.");

                }
                else
                {
                    continue;
                }

            }
            Console.WriteLine($"Subtotal: ${priceTotal:f2}");
            double moneyLeft = budget - priceTotal;
            if (moneyLeft>=0)
            {
                Console.WriteLine($"Money left: ${moneyLeft:f2}");
            }
            else
            {
                Console.WriteLine($"Not enough. We need ${-moneyLeft:f2} more.");
            }
        }
    }
}
