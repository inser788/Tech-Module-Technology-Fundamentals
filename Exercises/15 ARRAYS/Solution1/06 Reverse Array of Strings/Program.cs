﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine()
                .Split(' ')
                .ToArray();
            
            Array.Reverse(array);
            Console.WriteLine(string.Join(" ",array));
        }
    }
}
