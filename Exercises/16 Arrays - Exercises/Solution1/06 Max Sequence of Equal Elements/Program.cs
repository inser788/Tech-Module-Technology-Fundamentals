using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var start = 0;
            var length = 1;
            var bestStart = 0;
            var bestLength = 1;
            for (int currentElement = 1; currentElement < numbers.Length; currentElement++)
            {
                if (numbers[currentElement] == numbers[currentElement-1])
                {
                    length++;
                    start=numbers[currentElement];

                }
                else
                {
                    start = numbers[currentElement+1];
                    length = 1;
                }
                
            }
            


        }
    }
}
