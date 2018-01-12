using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01_Value_of_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string caseUpOrLow = Console.ReadLine();
            if (caseUpOrLow== "LOWERCASE")
            {
                var allLetters = new string(text.Where(x=>char.IsLetter(x)&&char.IsLower(x)).ToArray());
                int sumLetters = 0;
                for (int i = 0; i < allLetters.Length; i++)
                {
                    sumLetters += allLetters[i];
                }
                Console.WriteLine($"The total sum is: {sumLetters}");
            }
            else if (caseUpOrLow== "UPPERCASE")
            {
                var allLetters = new string(text.Where(x => char.IsLetter(x) && char.IsUpper(x)).ToArray());
                int sumLetters = 0;
                for (int i = 0; i < allLetters.Length; i++)
                {
                    sumLetters += allLetters[i];
                }
                Console.WriteLine($"The total sum is: {sumLetters}");
            }
        }
    }
}
