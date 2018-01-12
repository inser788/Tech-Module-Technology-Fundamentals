using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            while (true)
            {
                var commandInput = Console.ReadLine();

                if (commandInput == "3:1")
                    break;
                var listStrings = inputLine.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                var commandLine = commandInput.Split().ToArray();
                var command = commandLine.First();

                if (command == "merge")
                {
                    var startIndex = int.Parse(commandLine.Skip(1).First());
                    var endIndex = int.Parse(commandLine.Last());
                    if (startIndex < 0 || startIndex > listStrings.Count - 1)
                    {
                        startIndex = 0;
                    }
                    if (endIndex > listStrings.Count - 1 || endIndex < 0)
                    {
                        endIndex = listStrings.Count - 1;
                    }

                    var listOfItems = new List<string>();
                    for (int i = 0; i < startIndex; i++)
                    {
                        listOfItems.Add(listStrings[i]);
                    }
                    StringBuilder mergedItems = new StringBuilder();
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        mergedItems.Append(listStrings[i]);
                    }
                    listOfItems.Add(mergedItems.ToString());
                    for (int i = endIndex + 1; i <= listStrings.Count - 1; i++)
                    {
                        listOfItems.Add(listStrings[i]);
                    }
                    listStrings = listOfItems;
                    inputLine = (string.Join(" ", listOfItems));
                }
                else if (command == "divide")
                {
                    var index = int.Parse(commandLine.Skip(1).First());
                    var partitions = int.Parse(commandLine.Last());
                    if (partitions == 0 || partitions == 1)
                        continue;
                    var listOfItems = new List<string>();
                    for (int i = 0; i < index; i++)
                    {
                        listOfItems.Add(listStrings[i]);
                    }
                    var pieces = listStrings[index].Length / partitions;

                    if (listStrings[index].Length % partitions == 0)
                    {
                        for (int i = 0; i < listStrings[index].Length; i += pieces)
                        {
                            StringBuilder dividedItems = new StringBuilder();
                            dividedItems.Append(listStrings[index], i, pieces);
                            listOfItems.Add(dividedItems.ToString());
                        }
                    }
                    else
                    {
                        if (listStrings[index].Length % 2 == 0)
                        {
                            var p = 0;
                            for (int i = 0; i < partitions - pieces; i += pieces)
                            {
                                p = i;
                                StringBuilder dividedItems = new StringBuilder();
                                dividedItems.Append(listStrings[index], i, pieces);
                                listOfItems.Add(dividedItems.ToString());
                            }
                            StringBuilder dividedItemsLast = new StringBuilder();
                            dividedItemsLast.Append(listStrings[index], p + 1, (listStrings[index].Length / partitions) + 1);
                            listOfItems.Add(dividedItemsLast.ToString());
                        }
                        else
                        {
                            var p = 0;
                            for (int i = 0; i <= partitions - pieces; i += pieces)
                            {
                                p = i;
                                StringBuilder dividedItems = new StringBuilder();
                                dividedItems.Append(listStrings[index], i, pieces);
                                listOfItems.Add(dividedItems.ToString());
                            }
                            StringBuilder dividedItemsLast = new StringBuilder();
                            dividedItemsLast.Append(listStrings[index], p + pieces, (listStrings[index].Length / partitions) + pieces - 1);
                            listOfItems.Add(dividedItemsLast.ToString());
                        }
                    }
                    for (int i = index + 1; i <= listStrings.Count - 1; i++)
                    {
                        listOfItems.Add(listStrings[i]);
                    }
                    listStrings = listOfItems;
                    inputLine = (string.Join(" ", listOfItems));
                }
            }
            Console.WriteLine(string.Join(" ", inputLine));
        }
    }
}
