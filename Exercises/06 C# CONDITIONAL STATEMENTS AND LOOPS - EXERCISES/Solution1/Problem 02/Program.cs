using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            double quantityDrinks = double.Parse(Console.ReadLine());

            double price = 0.0;

            switch (profession)
            {
                case "Athlete": price = quantityDrinks * 0.70; Console.WriteLine($"The {profession} has to pay {price:f2}."); break;
                case "Businessman": price = quantityDrinks * 1.0; Console.WriteLine($"The {profession} has to pay {price:f2}."); break;
                case "Businesswoman": price = quantityDrinks * 1.0; Console.WriteLine($"The {profession} has to pay {price:f2}."); break;
                case "SoftUni Student": price = quantityDrinks * 1.7; Console.WriteLine($"The {profession} has to pay {price:f2}."); break;
                default: price = quantityDrinks * 1.2; Console.WriteLine($"The {profession} has to pay {price:f2}."); break;

            }
        }
    }
}