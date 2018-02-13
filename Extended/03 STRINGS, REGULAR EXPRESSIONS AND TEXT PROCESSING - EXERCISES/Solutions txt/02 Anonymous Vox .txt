using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02_Anonymous_Vox
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([A-Za-z]+)(.+)\1";

            string text = Console.ReadLine();
            var placeholders = Console.ReadLine()
                .Split("{}".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();

            MatchCollection matches = Regex.Matches(text, pattern);
            int i = 0;
            foreach (Match item in matches)
            {
                string newValue = item.Groups[1] + placeholders[i++] + item.Groups[1];
                text = text.Replace(item.ToString(), newValue);
            }
            Console.WriteLine(text);
        }
    }
}
