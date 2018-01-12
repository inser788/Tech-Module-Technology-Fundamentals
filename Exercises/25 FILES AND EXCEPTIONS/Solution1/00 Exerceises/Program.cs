using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Exerceises
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var startingIndex = int.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            var startingDamage = 1;
            var currentPosition = startingIndex;

            while (input != "Supernova")
            {


                var command = input.Split().ToArray();
                var direction = command[0];
                var indexesOfDirextion = int.Parse(command[1]);
                var counter = (startingIndex + indexesOfDirextion) - (arrayNumbers.Length - 1);
                var counter2 = startingIndex - indexesOfDirextion;
                switch (direction)
                {
                    case "right":
                        if ((startingIndex + indexesOfDirextion) >= arrayNumbers.Length - 1)
                        {
                            for (int i = startingIndex + 1; i < arrayNumbers.Length; i++)
                            {
                                arrayNumbers[i] -= startingDamage;
                                currentPosition = i;
                                counter--;
                            }
                            while (counter >= 0)
                            {
                                startingDamage++;

                                for (int i = 0; i < arrayNumbers.Length; i++)
                                {
                                    currentPosition = i;
                                    arrayNumbers[i] -= startingDamage;
                                    counter--;
                                    if (counter == -1)
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        currentPosition = i;
                                        arrayNumbers[i] -= startingDamage;
                                        counter--;
                                    }
                                }
                            }
                        }
                        else
                        {
                            for (int i = startingIndex; i <= indexesOfDirextion; i++)
                            {
                                arrayNumbers[i+1] -= startingDamage;
                                currentPosition = i+1;
                            }
                        }
                        input = Console.ReadLine();
                        startingIndex = currentPosition;
                        break;
                    case "left":
                        if (counter2 < 0)
                        {
                            for (int i = startingIndex - 1; i >= 0; i--)
                            {
                                arrayNumbers[i] -= startingDamage;
                                currentPosition = i;
                                counter2++;
                            }
                            while (counter2 < 0)
                            {
                                startingDamage++;
                                for (int i = arrayNumbers.Length - 1; i >= 0; i--)
                                {
                                    currentPosition = i;
                                    arrayNumbers[i] -= startingDamage;
                                    counter2++;
                                    if (counter2 == 2)
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            for (int i = startingIndex; i >= indexesOfDirextion-1; i--)
                            {
                                arrayNumbers[i-1] -= startingDamage;
                                currentPosition = i-1;

                            }
                        }
                        input = Console.ReadLine();
                        startingIndex = currentPosition;
                        break;


                }
            }
            Console.WriteLine(string.Join(" ", arrayNumbers));


        }
    }
}
