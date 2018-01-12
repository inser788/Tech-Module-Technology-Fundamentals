using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_Match_Hexadecimal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b(?:0x)?[A-F0-9]+\b";
            string text = Console.ReadLine();
            MatchCollection matchedText = Regex.Matches(text, regex);
            var output = matchedText.Cast<Match>().Select(a => a.Value).ToArray();
            Console.WriteLine(string.Join(" ",output));
        }
    }
}
