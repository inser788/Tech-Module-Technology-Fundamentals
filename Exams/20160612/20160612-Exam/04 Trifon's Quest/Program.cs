﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Trifon_s_Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            long startingHealth = long.Parse(Console.ReadLine());
            var rowsAndCols = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = rowsAndCols.First();
            int cols = rowsAndCols.Last();
            char[][] arrayQuest = new char[rows][];
            int[] playerPosition = new int[2];
            for (int row = 0; row < rows; row++)
            {
                arrayQuest[row] = Console.ReadLine().ToCharArray();
            }
            int turns = 0;
            for (int col = 0; col < arrayQuest[0].Length; col++)
            {
                if (col%2==0)  //moving down
                {
                    for (int row = 0; row < arrayQuest.Length; row++)
                    {
                        startingHealth = GetCurrentHealth(arrayQuest[row][col], turns, startingHealth);
                        turns = GetCurrentTurns(arrayQuest[row][col], turns);
                        if (startingHealth <= 0)
                        {
                            playerPosition = new int[] { row, col };
                            break;
                        }
                    }
                    
                }
                else //moving up
                {
                    for (int row = arrayQuest.Length-1; row >= 0; row--)
                    {
                        startingHealth = GetCurrentHealth(arrayQuest[row][col], turns, startingHealth);
                        turns = GetCurrentTurns(arrayQuest[row][col], turns);
                        if (startingHealth <= 0)
                        {
                            playerPosition = new int[] { row, col };
                            break;
                        }
                    }
                }
            }
            if (startingHealth>0)
            {
                Console.WriteLine("Quest completed!");
                Console.WriteLine($"Health: {startingHealth}");
                Console.WriteLine($"Turns: {turns}");
            }
            else
            {
                Console.WriteLine("Died at: ["+string.Join(", ",playerPosition)+"]");
            }
        }

        private static int GetCurrentTurns(char element, int turns)
        {
            if (element == 'T') turns += 2;
            turns++;
            return turns;
            
        }

        private static long GetCurrentHealth(char element, int turns, long startingHealth)
        {
            if (element == 'F') startingHealth -= turns / 2;
            else if (element == 'H') startingHealth += turns / 3;
            return startingHealth;
            
        }
    }
}
