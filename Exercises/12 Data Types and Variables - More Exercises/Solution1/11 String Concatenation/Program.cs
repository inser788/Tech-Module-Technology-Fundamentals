﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_String_Concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            char delimeter = char.Parse(Console.ReadLine());
            string sequance = Console.ReadLine();
            int numberOfLines = int.Parse(Console.ReadLine());
            string word = string.Empty;
            for (int i = 1; i <= numberOfLines; i++)
            {
                string line = Console.ReadLine();
                if (sequance == "even")
                {
                    if (i % 2 == 0)
                    {
                        word += line + delimeter;
                        continue;
                    }

                }
                else
                {
                    if (i % 2 != 0)
                    {
                        word += line + delimeter;
                        continue;
                    }


                }
            }
            Console.WriteLine(word.Remove(word.Length-1));

        }
    }
}