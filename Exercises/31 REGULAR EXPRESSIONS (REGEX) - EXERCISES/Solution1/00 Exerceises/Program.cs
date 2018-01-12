using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _00_Exerceises
{
    class Program
    {
        static void Main(string[] args)
        {
            var mainPattern = @"([^\?&=\s]*)=([^\?&=\s]*)";
            var patternForSpace = @"((%20|\+)+)";
            string input;
            while (!((input=Console.ReadLine())=="END"))
            {
                Dictionary<string, List<string>> listOfUsers = new Dictionary<string, List<string>>();
                var matches = Regex.Matches(input, mainPattern);
                for (int i = 0; i < matches.Count; i++)
                {
                    var key = matches[i].Groups[1].Value;
                    key = Regex.Replace(key, patternForSpace, " ").Trim();
                    var value = matches[i].Groups[2].Value;
                    value = Regex.Replace(value, patternForSpace, " ").Trim();
                    if (!listOfUsers.ContainsKey(key))
                    {
                        listOfUsers.Add(key, new List<string>());
                    }
                    if (!listOfUsers[key].Contains(value))
                    {
                        listOfUsers[key].Add(value);
                    }
                   
                }
                foreach (var item in listOfUsers)
                {
                    Console.Write($"{item.Key}=[{string.Join(", ", item.Value)}]");
                }
                Console.WriteLine();

            }
        }
    }
}
