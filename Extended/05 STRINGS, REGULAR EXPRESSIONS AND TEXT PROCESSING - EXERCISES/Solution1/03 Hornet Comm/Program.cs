using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_Hornet_Comm
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternMessage = @"^([\d]+) \<\-\> ([A-Za-z0-9]+)$";
            string patternBroadcast = @"^([^\d]+) \<\-\> ([A-Za-z0-9]+)$";

            var listOfMessages = new List<string>();
            var listOfBroadcasts = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Hornet is Green")
                    break;

                Match matchMessage = Regex.Match(input, patternMessage);
                Match matchBroadcast = Regex.Match(input, patternBroadcast);

                if (matchMessage.Success)
                {
                    string recepCode = matchMessage.Groups[1].Value;
                    recepCode = string.Join("", recepCode.ToCharArray().Reverse().ToArray());
                    string message = matchMessage.Groups[2].Value;
                    string result = recepCode + " -> " + message;
                    listOfMessages.Add(result);
                }
                if (matchBroadcast.Success)
                {
                    string message = matchBroadcast.Groups[1].Value;
                    char[] uncodeFrequancy = matchBroadcast.Groups[2].Value.ToCharArray();
                    for (int i = 0; i < uncodeFrequancy.Length; i++)
                    {
                        if (char.IsLower(uncodeFrequancy[i]))
                        {
                            uncodeFrequancy[i] = char.ToUpper(uncodeFrequancy[i]);
                        }
                        else if (char.IsUpper(uncodeFrequancy[i]))
                        {
                            uncodeFrequancy[i] = char.ToLower(uncodeFrequancy[i]);
                        }
                    }
                    string frequancy = new string(uncodeFrequancy);
                    string result = frequancy + " -> " + message;
                    listOfBroadcasts.Add(result);
                }
            }
            Console.WriteLine("Broadcasts:");
            if (listOfBroadcasts.Count==0)
            {
                Console.WriteLine("None");
            }
            else
            {
                listOfBroadcasts.ForEach(x => Console.WriteLine(x));
            }
            Console.WriteLine("Messages:");
            if (listOfMessages.Count==0)
            {
                Console.WriteLine("None");
            }
            else
            {
                listOfMessages.ForEach(x => Console.WriteLine(x));
            }

        }
    }
}
