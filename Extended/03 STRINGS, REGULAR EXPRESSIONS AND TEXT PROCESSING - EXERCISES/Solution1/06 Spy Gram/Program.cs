using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06_Spy_Gram
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^TO: ([A-Z]+); MESSAGE: (.+);$";

            var inputKey = Console.ReadLine().ToCharArray()
                .Select(x => int.Parse(x.ToString())).ToList();
            var listOfUncryptedMsg = new Dictionary<string, List<string>>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                    break;
                Match match = Regex.Match(input, pattern);
                if (!match.Success)
                    continue;
                string recepient = match.Groups[1].ToString();
                if (!listOfUncryptedMsg.ContainsKey(recepient))
                {
                    listOfUncryptedMsg[recepient] = new List<string>();
                }
                char[] charInput = input.ToCharArray();
                string cryptResult = string.Empty;
                int keyLengthMax = 0;
                for (int i = 0; i < charInput.Length; i++)
                {
                    if (keyLengthMax > inputKey.Count - 1)
                        keyLengthMax = 0;
                    char currentElement = charInput[i];
                    currentElement += (char)inputKey[keyLengthMax];
                    cryptResult += currentElement;
                    keyLengthMax++;
                }
                listOfUncryptedMsg[recepient].Add(cryptResult);
            }
            foreach (var name in listOfUncryptedMsg.OrderBy(x => x.Key))
            {
                foreach (var item in name.Value)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
