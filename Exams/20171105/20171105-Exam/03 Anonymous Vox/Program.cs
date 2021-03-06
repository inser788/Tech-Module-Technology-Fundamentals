﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_Anonymous_Vox
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"(([A-Za-z]+)(.*)\2)";

            string inputLineText = Console.ReadLine();
            var stringForReplace = Console.ReadLine().Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            MatchCollection collection = Regex.Matches(inputLineText, pattern);
            int i = 0;
            if (collection.Count==0)
            {
                Console.WriteLine(inputLineText);
                return;
            }
            else
            {
                foreach (Match match in collection)
                {
                    var matchStart = match.Groups[2].Value;
                    var patternReplace = match.Groups[3].Value;
                    if (collection.Count <= stringForReplace.Length)
                    {
                        var replace = stringForReplace[i];

                        string result = Regex.Replace(inputLineText, patternReplace, replace);
                        i++;
                        inputLineText = result;
                    }
                    else
                    {
                        if (i >= stringForReplace.Length)
                        {
                            i = 0;
                            var replace = stringForReplace[i];

                            string result = Regex.Replace(inputLineText, patternReplace, replace);
                            i++;
                            inputLineText = result;
                        }
                        else
                        {
                            var replace = stringForReplace[i];

                            string result = Regex.Replace(inputLineText, patternReplace, replace);
                            i++;
                            inputLineText = result;
                        }

                    }
                }
                
            }
            Console.WriteLine(inputLineText);


        }
    }
}
