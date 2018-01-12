using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double nights = double.Parse(Console.ReadLine());
            double priceStudio = 0.0;
            double priceDouble = 0.0;
            double priceSuite = 0.0;


            switch (month)
            {
                case "May":
                    if (nights>7)
                    {
                        priceStudio = (nights * 50) * 0.95;
                        priceDouble = nights * 65;
                        priceSuite = nights * 75;
                        Console.WriteLine($"Studio: {priceStudio:f2} lv.");
                        Console.WriteLine($"Double: {priceDouble:f2} lv.");
                        Console.WriteLine($"Suite: {priceSuite:f2} lv.");

                    }
                    else
                    {
                        priceStudio = nights * 50;
                        priceDouble = nights * 65;
                        priceSuite = nights * 75;
                        Console.WriteLine($"Studio: {priceStudio:f2} lv.");
                        Console.WriteLine($"Double: {priceDouble:f2} lv.");
                        Console.WriteLine($"Suite: {priceSuite:f2} lv.");

                    }
                    break;
                case "October":
                    if (nights > 7)
                    {
                        priceStudio = ((nights-1) * 50) * 0.95;
                        priceDouble = nights * 65;
                        priceSuite = nights * 75;
                        Console.WriteLine($"Studio: {priceStudio:f2} lv.");
                        Console.WriteLine($"Double: {priceDouble:f2} lv.");
                        Console.WriteLine($"Suite: {priceSuite:f2} lv.");
                    }
                    else
                    {
                        priceStudio = nights * 50;
                        priceDouble = nights * 65;
                        priceSuite = nights * 75;
                        Console.WriteLine($"Studio: {priceStudio:f2} lv.");
                        Console.WriteLine($"Double: {priceDouble:f2} lv.");
                        Console.WriteLine($"Suite: {priceSuite:f2} lv.");

                    }
                    break;
                case "June":
                    if (nights > 14)
                    {
                        priceStudio = (nights * 60);
                        priceDouble = (nights * 72)*0.90;
                        priceSuite = nights * 82;
                        Console.WriteLine($"Studio: {priceStudio:f2} lv.");
                        Console.WriteLine($"Double: {priceDouble:f2} lv.");
                        Console.WriteLine($"Suite: {priceSuite:f2} lv.");

                    }
                    else
                    {
                        priceStudio = nights * 60;
                        priceDouble = nights * 72;
                        priceSuite = nights * 82;
                        Console.WriteLine($"Studio: {priceStudio:f2} lv.");
                        Console.WriteLine($"Double: {priceDouble:f2} lv.");
                        Console.WriteLine($"Suite: {priceSuite:f2} lv.");

                    }
                    break;
                case "September":
                    if (nights > 7)
                    {
                        priceStudio = ((nights-1) * 60);
                        priceDouble = (nights * 72);
                        priceSuite = nights * 82;
                        Console.WriteLine($"Studio: {priceStudio:f2} lv.");
                        Console.WriteLine($"Double: {priceDouble:f2} lv.");
                        Console.WriteLine($"Suite: {priceSuite:f2} lv.");

                    }
                    else if (nights>14)
                    {
                        priceStudio = ((nights - 1) * 60);
                        priceDouble = (nights * 72)*0.90;
                        priceSuite = nights * 82;
                        Console.WriteLine($"Studio: {priceStudio:f2} lv.");
                        Console.WriteLine($"Double: {priceDouble:f2} lv.");
                        Console.WriteLine($"Suite: {priceSuite:f2} lv.");
                    }
                    else
                    {
                        priceStudio = nights * 60;
                        priceDouble = nights * 72;
                        priceSuite = nights * 82;
                        Console.WriteLine($"Studio: {priceStudio:f2} lv.");
                        Console.WriteLine($"Double: {priceDouble:f2} lv.");
                        Console.WriteLine($"Suite: {priceSuite:f2} lv.");

                    }
                    break;
                case "July":
                    if (nights > 14)
                    {
                        priceStudio = (nights * 68);
                        priceDouble = nights * 77;
                        priceSuite = (nights * 89)*0.85;
                        Console.WriteLine($"Studio: {priceStudio:f2} lv.");
                        Console.WriteLine($"Double: {priceDouble:f2} lv.");
                        Console.WriteLine($"Suite: {priceSuite:f2} lv.");

                    }
                    else
                    {
                        priceStudio = nights * 68;
                        priceDouble = nights * 77;
                        priceSuite = nights * 89;
                        Console.WriteLine($"Studio: {priceStudio:f2} lv.");
                        Console.WriteLine($"Double: {priceDouble:f2} lv.");
                        Console.WriteLine($"Suite: {priceSuite:f2} lv.");

                    }
                    break;
                case "August":
                    if (nights > 14)
                    {
                        priceStudio = (nights * 68);
                        priceDouble = nights * 77;
                        priceSuite = (nights * 89) * 0.85;
                        Console.WriteLine($"Studio: {priceStudio:f2} lv.");
                        Console.WriteLine($"Double: {priceDouble:f2} lv.");
                        Console.WriteLine($"Suite: {priceSuite:f2} lv.");

                    }
                    else
                    {
                        priceStudio = nights * 68;
                        priceDouble = nights * 77;
                        priceSuite = nights * 89;
                        Console.WriteLine($"Studio: {priceStudio:f2} lv.");
                        Console.WriteLine($"Double: {priceDouble:f2} lv.");
                        Console.WriteLine($"Suite: {priceSuite:f2} lv.");

                    }
                    break;
                case "December":
                    if (nights > 14)
                    {
                        priceStudio = (nights * 68);
                        priceDouble = nights * 77;
                        priceSuite = (nights * 89) * 0.85;
                        Console.WriteLine($"Studio: {priceStudio:f2} lv.");
                        Console.WriteLine($"Double: {priceDouble:f2} lv.");
                        Console.WriteLine($"Suite: {priceSuite:f2} lv.");

                    }
                    else
                    {
                        priceStudio = nights * 68;
                        priceDouble = nights * 77;
                        priceSuite = nights * 89;
                        Console.WriteLine($"Studio: {priceStudio:f2} lv.");
                        Console.WriteLine($"Double: {priceDouble:f2} lv.");
                        Console.WriteLine($"Suite: {priceSuite:f2} lv.");

                    }
                    break;

            }
        }
    }
}
