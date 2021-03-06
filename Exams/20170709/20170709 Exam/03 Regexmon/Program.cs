﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternDidi = @"(?<=^|[A-Za-z\-])([^A-Za-z\-]+)(?=$|[A-Za-z\-])";
            string patternBojo = @"(?<=^|[^A-Za-z])([A-Za-z]+)-([A-Za-z]+)(?=$|[^A-Za-z])";
            string inputLine = Console.ReadLine();
            StringBuilder cutSentence = new StringBuilder();
            cutSentence.Append(inputLine);
            int counter = 1;
            while (true)
            {
                if (counter % 2 != 0)
                {
                    var collection = Regex.Match(cutSentence.ToString(), patternDidi);
                    if (!collection.Success)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine(collection.Value);
                        var matchIndex = collection.Index;
                        var matchLength = collection.Length;
                        counter++;
                        if (matchIndex == 0)
                        {
                            cutSentence.Remove(0, matchLength);
                        }
                        else
                        {
                            cutSentence.Remove(0, matchLength + matchIndex);
                        }
                    }
                }
                else
                {
                    var collection = Regex.Match(cutSentence.ToString(), patternBojo);
                    if (!collection.Success)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine(collection.Value);
                        var matchIndex = collection.Index;
                        var matchLength = collection.Length;
                        counter++;
                        if (matchIndex == 0)
                        {
                            cutSentence.Remove(0, matchLength);
                        }
                        else
                        {
                            cutSentence.Remove(0, matchLength + matchIndex);
                        }
                    }
                }
            }
            
        }
    }
}
