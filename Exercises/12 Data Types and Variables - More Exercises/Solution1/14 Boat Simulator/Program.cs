using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Boat_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstBoatSymbol = char.Parse(Console.ReadLine());
            char secondBoatSymbol = char.Parse(Console.ReadLine());
            int numberOfMoves = int.Parse(Console.ReadLine());

            int newFirstBoatNumber = firstBoatSymbol;
            int newSecondBoatNumber = secondBoatSymbol;

            int pointsBoatOne = 0;
            int pointsBoatTwo = 0;
            for (int i = 1; i <= numberOfMoves; i++)
            {
                string message = Console.ReadLine();
                if (message== "UPGRADE")
                {
                    newFirstBoatNumber += 3;
                    newSecondBoatNumber += 3;
                    continue;

                }
                if (i%2!=0)
                {
                    pointsBoatOne += message.Length;
                }
                else
                {
                    pointsBoatTwo += message.Length;

                }
                if (pointsBoatOne>=50)
                {
                    Console.WriteLine((char)newFirstBoatNumber);
                    return;
                }
                else if (pointsBoatTwo>=50)
                {
                    Console.WriteLine((char)newSecondBoatNumber);
                    return;

                }


            }
            
                if (pointsBoatOne > pointsBoatTwo)
                {
                    Console.WriteLine((char)newFirstBoatNumber);

                }
                else
                {
                    Console.WriteLine((char)newSecondBoatNumber);

                }
            


        }
    }
}
