﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Weather_Forecast
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte number;
            int number1;
            long number2;
            string line = Console.ReadLine();
            if (line.Contains('.'))
            {
                Console.WriteLine("Rainy");
            }
            else
            {

                var canFitInSbyte = sbyte.TryParse(line, out number);
                if (canFitInSbyte)
                {
                    Console.WriteLine("Sunny");
                }
                else
                {
                    var canFitInInt = int.TryParse(line, out number1);
                    if (canFitInInt)
                    {
                        Console.WriteLine("Cloudy");
                    }
                    else
                    {
                        var canFitIntLong = long.TryParse(line, out number2);
                        if (canFitIntLong)
                        {
                            Console.WriteLine("Windy");
                        }
                    }
                }
            }
        }
    }
}
