using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02_Diamond_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\<.+?\>)";
            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);
            if (matches.Count == 0)
            {
                Console.WriteLine("Better luck next time");
                return;
            }
            foreach (Match m in matches)
            {
                var allDigits =new string(m.ToString().Where(x => char.IsDigit(x)).ToArray());
                var digitsToChar = allDigits.ToCharArray();
                var sum = digitsToChar.Sum(x => int.Parse(x.ToString()));
                Console.WriteLine($"Found {sum} carat diamond");
            }
        }
    }
}
