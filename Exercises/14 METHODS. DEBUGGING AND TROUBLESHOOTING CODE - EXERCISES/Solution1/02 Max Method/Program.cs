﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMaxNumber(a,b,c));

        }
        static int GetMaxNumber(int a,int b,int c)
        {
            int value = Math.Max(a, b);
            if (value<c)
            {
                return c;
            }
            else
            {
                return value;
            }
        }
    }
}