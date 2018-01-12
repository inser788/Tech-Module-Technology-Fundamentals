using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03English_NameofLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            GetEnglishNameOfLastDigit(number);

        }
        static void GetEnglishNameOfLastDigit(int number)
        {
            int value = number % 10;
            if (value==0)
            {
                Console.WriteLine("zero");
            }
            else if (value==1)
            {
                Console.WriteLine("one");
            }
            else if (value == 2)
            {
                Console.WriteLine("two");
            }
            else if (value == 3)
            {
                Console.WriteLine("three");
            }
            else if (value == 4)
            {
                Console.WriteLine("four");
            }
            else if (value == 5)
            {
                Console.WriteLine("five");
            }
            else if (value == 6)
            {
                Console.WriteLine("six");
            }
            else if (value == 7)
            {
                Console.WriteLine("seven");
            }
            else if (value == 8)
            {
                Console.WriteLine("eight");
            }
            else if (value == 9)
            {
                Console.WriteLine("nine");
            }

        }
    }
}
