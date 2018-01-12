using System;

using System.Linq;


namespace _03_Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] firstNumbers = new int[numbers.Length / 4];
            int[] lastNumbers = new int[numbers.Length / 4];
            int[] middleNumbers = new int[numbers.Length / 2];


            for (int i = 0; i < firstNumbers.Length; i++)
            {
                firstNumbers[i] = numbers[i];
            }
            for (int i = numbers.Length-1; i >= (numbers.Length)/4*3; i--)
            {
                lastNumbers[numbers.Length-1-i] = numbers[i];
            }
            for (int i = 0; i < middleNumbers.Length; i++)
            {
                middleNumbers[i] = numbers[(numbers.Length/4)+i];
            }
            Array.Reverse(firstNumbers);
            
            int[] sumOfAll = new int[middleNumbers.Length];
            for (int i = 0; i < middleNumbers.Length/2; i++)
            {
                sumOfAll[i] = firstNumbers[i] + middleNumbers[i];
            }
            for (int i = middleNumbers.Length/2; i < middleNumbers.Length; i++)
            {
                sumOfAll[i] = lastNumbers[i-middleNumbers.Length/2] + middleNumbers[i];
            }
            Console.WriteLine(string.Join(" ", sumOfAll));







        }
    }
}
