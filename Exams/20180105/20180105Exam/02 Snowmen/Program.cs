using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Snowmen
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequanceOfElements = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var listOfLosers = new List<int>();
            var listOfWinners = new List<int>();


            

            for (int i = 0; i < sequanceOfElements.Count; i++)
            {

                var attackerIndex = i;
                var attackerElement = sequanceOfElements[i];
                if (attackerElement > sequanceOfElements.Count)
                {
                    attackerElement = attackerElement % sequanceOfElements.Count;
                }
                var targetIndex = attackerElement; ;
                if (targetIndex > sequanceOfElements.Count)
                {
                    targetIndex = targetIndex % sequanceOfElements.Count;
                }
              
                var elementAtTarget = sequanceOfElements.ElementAt(targetIndex);

                var difference = Math.Abs(attackerElement - elementAtTarget);

                if (difference % 2 == 0 && difference != 0)
                {
                    //attacker wins
                    listOfLosers.Add(targetIndex);
                    listOfWinners.Add(attackerElement);
                    // Console.WriteLine($"{attackerIndex} x {targetIndex} -> {attackerIndex} wins");
                }
                else if (difference % 2 == 1 && difference != 0)
                {
                    //target wins
                    //  Console.WriteLine($"{attackerIndex} x {targetIndex} -> {targetIndex} wins");
                    listOfLosers.Add(attackerIndex);
                    listOfWinners.Add(elementAtTarget);

                }
                else if(difference==0)
                {
                    //attackerElement makes harakiri
                    listOfLosers.Add(targetIndex);
                    Console.WriteLine($"{attackerIndex} performed harakiri");

                    if (sequanceOfElements.Count == 2)
                    {
                        return;
                    }
                    
                }
                if (difference % 2 == 0 && difference != 0&&!listOfLosers.Contains(i))
                {
                    //attacker wins
                     Console.WriteLine($"{attackerIndex} x {targetIndex} -> {attackerIndex} wins");
                }
                else if (difference % 2 == 1 && difference != 0 && !listOfLosers.Contains(i))
                {
                    //target wins
                    
                      Console.WriteLine($"{attackerIndex} x {targetIndex} -> {targetIndex} wins");
                }
                var sumAll = listOfWinners.Count + listOfLosers.Count;
                if (sumAll==sequanceOfElements.Count)
                {
                    // for (int j = 0; j < listOfLosers.Count; j++)
                    // {
                    //     sequanceOfElements.RemoveAt(listOfLosers[i]);
                    //     i = 0;
                    // }
                    var resultSequance = listOfWinners.ToList();
                    listOfWinners.Clear();
                    listOfLosers.Clear();
                    sequanceOfElements = resultSequance;

                    i = -1;
                    if (sequanceOfElements.Count==1)
                    {
                        return;
                    }
                    
                }
             
            }
        }
    }
}
