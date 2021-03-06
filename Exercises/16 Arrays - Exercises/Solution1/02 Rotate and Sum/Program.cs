﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numberOfRotations = int.Parse(Console.ReadLine());

            int[] arrayRotateSum = new int[numbers.Length];
            for (int i = 0; i < numberOfRotations; i++)
            {
                var lastElement = numbers[numbers.Length-1];
                for (int j = numbers.Length-1; j > 0; j--)
                {
                    numbers[j] = numbers[j - 1];
                }
                numbers[0] = lastElement;
                for (int k = 0; k < numbers.Length; k++)
                {
                    arrayRotateSum[k] += numbers[k];
                }
                
            }
                Console.WriteLine(string.Join(" ",arrayRotateSum));


        }
    }
}
