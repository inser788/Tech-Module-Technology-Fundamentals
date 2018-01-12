using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_Phoenix_Grid
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^([^\s_]{3})(\.([^\s_]{3}))*$";

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "ReadMe")
                    break;
                var match = Regex.Match(line, pattern);
                if (!match.Success)
                {
                    Console.WriteLine("NO");
                    continue;
                }
                var word = match.ToString();
                var reversedWord = word.ToCharArray();
                Array.Reverse(reversedWord);
                string result = new string(reversedWord);
                if (word.Equals(result))
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
