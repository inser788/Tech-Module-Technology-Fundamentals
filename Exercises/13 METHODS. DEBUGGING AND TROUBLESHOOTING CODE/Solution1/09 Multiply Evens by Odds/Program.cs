﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));
            GetSumOfEven(n);
            GetSumOfOdd(n);

            GetMultipleFromOddAndEven(n);
            
        }
        static void GetMultipleFromOddAndEven(int n)
        {
            int Even = GetSumOfEven(n);
            int Odd = GetSumOfOdd(n);
             Console.WriteLine(Even*Odd);
            
        }
        static int GetSumOfEven(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit%2==0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;

        }
        static int GetSumOfOdd(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;


        }
    }
}
