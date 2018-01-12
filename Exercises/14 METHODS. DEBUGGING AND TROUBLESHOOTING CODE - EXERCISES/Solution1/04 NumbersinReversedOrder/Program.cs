using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_NumbersinReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());
            decimal reversedNumber = GetReversedNumber(number);
            Console.WriteLine(reversedNumber);


        }

        private static decimal GetReversedNumber(decimal number)
        {
            string numberToString = number.ToString();
            string result = string.Empty;
            for (int i = numberToString.Length-1; i >= 0; i--)
            {
                result += numberToString[i];
            }
            return decimal.Parse(result);
        }
    }
}
