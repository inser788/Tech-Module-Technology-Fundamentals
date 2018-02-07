﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Icarus
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequanceNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int startindex = int.Parse(Console.ReadLine());
            var damage = 1;
            int count = sequanceNumbers.Count();
            while (true)
            {
                var line = Console.ReadLine().Split().ToArray();
                if (line.First() == "Supernova")
                    break;
                var commandMove = line.First();
                var movements = int.Parse(line.Last());

                if (commandMove == "right" && movements != 0)
                {
                    for (int i = 0; i < movements; i++)
                    {
                        if (startindex >= count - 1)

                        {
                            damage++;
                            startindex = -1;
                        }
                        sequanceNumbers[startindex + 1] -= damage;
                        startindex++;
                    }
                }
                else if (commandMove == "left" && movements != 0)
                {
                    for (int i = 0; i < movements; i++)
                    {
                        if (startindex <= 0)
                        {
                            damage++;
                            startindex = count;
                        }
                        sequanceNumbers[startindex - 1] -= damage;
                        startindex--;
                    }
                }
            }
            Console.WriteLine(string.Join(" ",sequanceNumbers));

        }
    }
}