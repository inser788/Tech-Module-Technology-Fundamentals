using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01_Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b(([A-Z][a-z]+) ([A-Z][a-z]+))\b";
            string text = Console.ReadLine();
            MatchCollection matchedText = Regex.Matches(text, regex);
            foreach (Match name in matchedText)
            {
                Console.Write(name.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
