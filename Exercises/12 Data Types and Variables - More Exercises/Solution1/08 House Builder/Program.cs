﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_House_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());

            double priceIntegers = Math.Max(numberOne, numberTwo) * 10;
            double priceSbytes = Math.Min(numberOne, numberTwo) * 4;
            double priceAll = priceIntegers + priceSbytes;
            Console.WriteLine(priceAll);


        }
    }
}
