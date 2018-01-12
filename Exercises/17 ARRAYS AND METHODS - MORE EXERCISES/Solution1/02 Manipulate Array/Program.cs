using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Manipulate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wordsArray = Console.ReadLine().Split().ToArray();
            int numberOfCommands = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < numberOfCommands; i++)
            {

                string[] command = Console.ReadLine().Split();
                var commandUse = command[0];
                switch (commandUse)
                {
                    case "Reverse": Array.Reverse(wordsArray); break;
                    case "Distinct": wordsArray = wordsArray.Distinct().ToArray(); break;
                    case "Replace":
                        var indexReplace = int.Parse(command[1]);
                        var wordForReplace = command[2];
                        wordsArray[indexReplace] = wordForReplace;
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", wordsArray));

        }


    }
}
