﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string reversedText = new string(text.ToCharArray().Reverse().ToArray());
            Console.WriteLine(reversedText);
        }
    }
}