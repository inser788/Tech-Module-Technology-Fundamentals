using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(long.Parse).ToList();
            var removedItems = new List<long>();
            bool isOk = true;
            while (isOk)
            {
                var indexOfElement = int.Parse(Console.ReadLine());
                if (indexOfElement < 0)
                {
                    removedItems.Add(input[0]);
                    for (int i = 1; i < input.Count; i++)
                    {
                        if (input[0] >= input[i])
                        {
                            input[i] += input[0];
                        }
                        else
                        {
                            input[i] -= input[0];
                        }
                    }
                    input.RemoveAt(0);
                    var addedNumber = input.Last();
                    input.Insert(0, addedNumber);
                }
                else if (indexOfElement > input.Count - 1)
                {
                    removedItems.Add(input[input.Count - 1]);
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[input.Count - 1] >= input[i])
                        {
                            input[i] += input[input.Count - 1];
                        }
                        else
                        {
                            input[i] -= input[input.Count - 1];
                        }
                    }
                    input.RemoveAt(input.Count - 1);
                    input.Add(input.First());
                }
                else
                {
                    removedItems.Add(input[indexOfElement]);
                    var numberforRemove = input[indexOfElement];
                    input.RemoveAt(indexOfElement);


                    for (int i = 0; i < input.Count; i++)
                    {
                        if (numberforRemove >= input[i])
                        {
                            input[i] +=numberforRemove;
                        }
                        else
                        {
                            input[i] -= numberforRemove;
                        }
                    }


                }
                var whenStop = input.Count();
                if (whenStop==0)
                {
                    Console.WriteLine(removedItems.Sum());
                    isOk = false;
                    return;
                }
            }
        }
    }
}
