using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputLine = Console.ReadLine()
                .Split(new char[] { ' ', '\t', ',','\n' }, StringSplitOptions
                .RemoveEmptyEntries).ToArray();

            for (int i = 0; i < inputLine.Length; i++)
            {
                var currentElement = inputLine[i].Trim();
                if (currentElement.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                var leftSide = currentElement.ToCharArray();
                var leftSideList = new Dictionary<char, int>();
                for (int j = 0; j < leftSide.Length / 2; j++)
                {
                    var currentChar = leftSide[j];
                    if (!leftSideList.ContainsKey(currentChar))
                    {
                        leftSideList[currentChar] = 1;
                    }
                    else
                    {
                        leftSideList[currentChar]++;

                    }

                }
                var orderedListLeft = leftSideList.OrderByDescending(x => x.Value)
                                          .ToDictionary(k => k.Key, v => v.Value);
                if (orderedListLeft.Values.First() < 6)
                {
                    Console.WriteLine($"ticket \"{currentElement}\" - no match");
                    continue;
                }
                var reversedArrayRight = new char[20];
                Array.Copy(leftSide, reversedArrayRight, 20);
                Array.Reverse(reversedArrayRight);
                var rightSideList = new Dictionary<char, int>();
                for (int j = 0; j < reversedArrayRight.Length / 2; j++)
                {
                    var currentChar = reversedArrayRight[j];
                    if (!rightSideList.ContainsKey(currentChar))
                    {
                        rightSideList[currentChar] = 1;
                    }
                    else
                    {
                        rightSideList[currentChar]++;

                    }

                }
                var orderedListRight = rightSideList.OrderByDescending(x => x.Value)
                                         .ToDictionary(k => k.Key, v => v.Value);
                var mostRepeatedSymbolLeft = orderedListLeft.Keys.First();
                var timesRepetedleft = orderedListLeft.Values.First();
                var mostRepeatedSymbolRight = orderedListRight.Keys.First();
                var timesRepetedRight = orderedListRight.Values.First();
                if (timesRepetedleft == 10 && timesRepetedRight == 10 && mostRepeatedSymbolLeft == mostRepeatedSymbolRight
                    &&( mostRepeatedSymbolLeft=='@'|| mostRepeatedSymbolLeft == '#'|| mostRepeatedSymbolLeft == '$'
                    || mostRepeatedSymbolLeft == '^'))
                {
                    Console.WriteLine($"ticket \"{currentElement}\" - 10{mostRepeatedSymbolLeft} Jackpot!");

                }
                else if (timesRepetedleft == timesRepetedRight && mostRepeatedSymbolLeft == mostRepeatedSymbolRight
                    && (mostRepeatedSymbolLeft == '@' || mostRepeatedSymbolLeft == '#' || mostRepeatedSymbolLeft == '$'
                    || mostRepeatedSymbolLeft == '^'))
                {
                    Console.WriteLine($"ticket \"{currentElement}\" - {timesRepetedleft}{mostRepeatedSymbolLeft}");
                }
                else if (mostRepeatedSymbolLeft==mostRepeatedSymbolRight&&timesRepetedleft>timesRepetedRight)
                {
                    Console.WriteLine($"ticket \"{currentElement}\" - {timesRepetedRight}{mostRepeatedSymbolLeft}");

                }
                else if (mostRepeatedSymbolLeft == mostRepeatedSymbolRight && timesRepetedleft < timesRepetedRight)
                {
                    Console.WriteLine($"ticket \"{currentElement}\" - {timesRepetedleft}{mostRepeatedSymbolLeft}");

                }
                else if (mostRepeatedSymbolLeft!=mostRepeatedSymbolRight)
                {
                    Console.WriteLine($"ticket \"{currentElement}\" - no match");
                    continue;
                }
            }
        }
    }
}
