using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02_Worm_Ipsum
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                string input = Console.ReadLine();
                if (input== "Worm Ipsum")
                {
                    break;
                }
                var patterSentence = @"^[A-Z][^\.]*\.$";

                var match = Regex.Match(input, patterSentence);
                if (!match.Success)
                {
                    continue;
                }
                var sentence = match.ToString().Split(' ').ToArray();
                var newSentence = new List<string>();
                for (int i = 0; i < sentence.Length; i++)
                {
                    var word = sentence[i];
                    var wordToChar = word.ToCharArray();
                    var countPerNum = new Dictionary<char, int>();
                    for (int j = 0; j < word.Length; j++)
                    {
                        var currentLetter = wordToChar[j];
                        if (!countPerNum.ContainsKey(wordToChar[j]))
                        {
                            countPerNum.Add(wordToChar[j], 0);
                        }
                        countPerNum[wordToChar[j]]++;
                    }
                    var orderedItems = countPerNum.OrderByDescending(x => x.Value).ToArray();
                    var item = orderedItems.First();
                    string charForReplace = item.Key.ToString();
                    int itemValue = int.Parse(item.Value.ToString());
                    var patternReplace = @"([A-Za-z])";
                    if (itemValue == 1)
                    {
                        newSentence.Add(word);
                    }
                    else
                    {
                        var newWord = Regex.Replace(word, patternReplace, charForReplace);
                        newSentence.Add(newWord);
                    }
                }
                Console.WriteLine(string.Join(" ", newSentence));
            }
        }
    }
}
