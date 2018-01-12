using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfStrings = Console.ReadLine().Split().ToList();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "3:1")
                    break;
                var commandsInput = input.Split().ToList();
                string command = commandsInput.First();
                if (command == "merge")
                {
                    int startIndex = int.Parse(commandsInput.Skip(1).First());
                    int endIndex = int.Parse(commandsInput.Last());
                    if (startIndex < 0 || startIndex > listOfStrings.Count - 1)
                    {
                        startIndex = 0;
                    }
                    if (endIndex > listOfStrings.Count - 1 || endIndex < 0)
                    {
                        endIndex = listOfStrings.Count - 1;

                    }
                    var resultList = new List<string>();
                    resultList.AddRange(listOfStrings.GetRange(0, startIndex));
                    StringBuilder sb = new StringBuilder();

                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        sb.Append(listOfStrings[i]);
                    }
                    resultList.Add(sb.ToString());
                    resultList.AddRange(listOfStrings.GetRange(endIndex + 1, listOfStrings.Count - 1 - endIndex));
                    listOfStrings = resultList;
                }
                else
                {
                    int index = int.Parse(commandsInput.Skip(1).First());
                    int parts = int.Parse(commandsInput.Last());
                    var resultList = new List<string>();
                    resultList.AddRange(listOfStrings.GetRange(0, index));
                    var currentElement = listOfStrings[index];
                    var currentLength = currentElement.Length;
                    var divideMod = currentLength % parts;
                    var divideParts = currentLength / parts;
                    if (divideMod == 0)
                    {
                        for (int i = 0; i < currentLength; i += divideParts)
                        {
                            var sub = currentElement.Substring(i, divideParts);
                            resultList.Add(sub);
                        }
                        resultList.AddRange(listOfStrings.GetRange(index + 1, listOfStrings.Count - 1 - index));
                        listOfStrings = resultList;
                    }
                    else
                    {
                        for (int i = 0; i < currentLength; i += divideParts)
                        {
                            if (i == currentLength - 1 - divideParts)
                            {
                                var subLast = currentElement.Substring(i);
                                resultList.Add(subLast);
                                break;
                            }
                            var sub = currentElement.Substring(i, divideParts);
                            resultList.Add(sub);
                        }
                        resultList.AddRange(listOfStrings.GetRange(index + 1, listOfStrings.Count - 1 - index));
                        listOfStrings = resultList;
                    }

                }

            }
            Console.WriteLine(string.Join(" ", listOfStrings));

        }
    }
}
