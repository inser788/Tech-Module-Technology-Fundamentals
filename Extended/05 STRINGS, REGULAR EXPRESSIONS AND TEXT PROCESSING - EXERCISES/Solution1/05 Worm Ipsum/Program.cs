using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05_Worm_Ipsum
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^[A-Z][^\.]*(\.{1})$";

            while (true)
            {
                string lineInput = Console.ReadLine();
                if (lineInput == "Worm Ipsum")
                    break;
                Match match = Regex.Match(lineInput, pattern);
                if (!match.Success)
                    continue;
                var words = match.ToString()
                    .Split()
                    .ToArray();
                var result = string.Empty;
                for (int i = 0; i < words.Length; i++)
                {
                    var currentWord = words[i];

                    Dictionary<char, int> chars = new Dictionary<char, int>();

                    foreach (char c in currentWord)
                    {
                        if (chars.ContainsKey(c)) chars[c]++;
                        else chars.Add(c, 1);
                    }
                    int maxValue = chars.Values.Max();
                    chars = chars.OrderByDescending(x => x.Value).ToDictionary(k=>k.Key,v=>v.Value);
                    string replacePattern = @"[A-Za-z]";
                    if (maxValue != 1)
                    {
                         currentWord = Regex.Replace(currentWord, replacePattern, chars.Keys.First().ToString());
                    }
                    result += currentWord + " ";
                }
                Console.WriteLine(result.TrimEnd());
            }
        }
    }
}
