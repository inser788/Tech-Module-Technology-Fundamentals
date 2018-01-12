using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Jump_Around
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbersInArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var currentPosition = 0;
            var currentNumber = 0;
            var sumOfAll = 0;
            for (int i = 0; i < int.MaxValue; i++)
            {
                
                currentNumber = numbersInArray[0];
                if (currentNumber>numbersInArray.Length)
                {
                    sumOfAll = currentNumber;
                    Console.WriteLine(sumOfAll);
                    return;
                }
                else
                {
                    currentPosition = numbersInArray.Length - currentNumber+1;
                    currentNumber = numbersInArray[currentPosition];
                }
            }
        }
    }
}
