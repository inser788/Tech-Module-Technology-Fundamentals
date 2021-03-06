﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbersInList = Console.ReadLine().Split().Select(int.Parse).ToList();
            var manupulatedNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            numbersInList = numbersInList
                 .Take(manupulatedNumbers[0])
                 .Skip(manupulatedNumbers[1])
                 .ToList();
            if (numbersInList.Contains(manupulatedNumbers[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
