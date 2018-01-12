using System;
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
            var sequance = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int startIndex = int.Parse(Console.ReadLine());
            int damage = 1;
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Supernova")
                    break;
                var command = input.Split().ToArray();
                string direction = command.First();
                int steps = int.Parse(command.Last());
                int sequanceLength = sequance.Count;
                if (direction=="left")
                {
                    for (int i = 0; i < steps; i++)
                    {
                        if (startIndex <= 0)
                        {
                            startIndex = sequanceLength - 1;
                            damage++;
                            sequance[startIndex]-=damage;
                            continue;
                        }
                        startIndex--;
                        sequance[startIndex] -= damage;
                    }
                }
                else
                {
                    for (int i = 0; i < steps; i++)
                    {
                        if (startIndex>=sequanceLength-1)
                        {
                            startIndex = 0;
                            damage++;
                            sequance[startIndex] -= damage;
                            continue;
                        }
                        startIndex++;
                        sequance[startIndex] -= damage;
                    }
                }
            }
            Console.WriteLine(string.Join(" ",sequance));
        }
    }
}
