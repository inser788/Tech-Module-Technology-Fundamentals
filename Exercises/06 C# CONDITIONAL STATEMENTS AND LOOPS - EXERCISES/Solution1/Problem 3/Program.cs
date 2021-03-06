﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double groupSize = double.Parse(Console.ReadLine());
            string packegeDiscount = Console.ReadLine();
            double totalPrice = 0.0;
            


            if (groupSize> 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                switch (packegeDiscount)
                {
                    case "Normal":
                        if (groupSize<=50)
                        {
                            totalPrice = 3000*0.95;
                            Console.WriteLine("We can offer you the Small Hall");
                            Console.WriteLine($"The price per person is {(totalPrice/groupSize):f2}$");
                        }
                        else if (groupSize>50 && groupSize<=100)
                        {
                            totalPrice = 5500 * 0.95;
                            Console.WriteLine("We can offer you the Terrace");
                            Console.WriteLine($"The price per person is {(totalPrice / groupSize):f2}$");
                        }
                        else
                        {
                            totalPrice = 8000 * 0.95;
                            Console.WriteLine("We can offer you the Great Hall");
                            Console.WriteLine($"The price per person is {(totalPrice / groupSize):f2}$");
                        }
                        break;
                    case "Gold":
                        if (groupSize <= 50)
                        {
                            totalPrice = 3250 * 0.90;
                            Console.WriteLine("We can offer you the Small Hall");
                            Console.WriteLine($"The price per person is {(totalPrice / groupSize):f2}$");
                        }
                        else if (groupSize > 50 && groupSize <= 100)
                        {
                            totalPrice = 5750 * 0.90;
                            Console.WriteLine("We can offer you the Terrace");
                            Console.WriteLine($"The price per person is {(totalPrice / groupSize):f2}$");
                        }
                        else
                        {
                            totalPrice = 8250 * 0.90;
                            Console.WriteLine("We can offer you the Great Hall");
                            Console.WriteLine($"The price per person is {(totalPrice / groupSize):f2}$");
                        }
                        break;
                    case "Platinum":
                        if (groupSize <= 50)
                        {
                            totalPrice = 3500 * 0.85;
                            Console.WriteLine("We can offer you the Small Hall");
                            Console.WriteLine($"The price per person is {(totalPrice / groupSize):f2}$");
                        }
                        else if (groupSize > 50 && groupSize <= 100)
                        {
                            totalPrice = 6000 * 0.85;
                            Console.WriteLine("We can offer you the Terrace");
                            Console.WriteLine($"The price per person is {(totalPrice / groupSize):f2}$");
                        }
                        else
                        {
                            totalPrice = 8500 * 0.85;
                            Console.WriteLine("We can offer you the Great Hall");
                            Console.WriteLine($"The price per person is {(totalPrice / groupSize):f2}$");
                        }
                        break;
                }
            }
        }
    }
}
