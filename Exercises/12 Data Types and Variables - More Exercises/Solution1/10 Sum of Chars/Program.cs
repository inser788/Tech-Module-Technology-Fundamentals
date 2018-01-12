using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCharachters = int.Parse(Console.ReadLine());
            long word = 0l;
            for (int i = 0; i < numberOfCharachters; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                word += symbol;

            }
            Console.WriteLine($"The sum equals: {word}");
        }
    }
}
