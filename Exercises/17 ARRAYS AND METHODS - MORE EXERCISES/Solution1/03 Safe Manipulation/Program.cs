using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Safe_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wordsArray = Console.ReadLine().Split().ToArray();

            while(true)
            {

                string[] command = Console.ReadLine().Split();
                
                var commandUse = command[0];
                if (commandUse == "END")
                {
                    break;
                }
                switch (commandUse)
                {
                    case "Reverse": Array.Reverse(wordsArray); break;
                    case "Distinct": wordsArray = wordsArray.Distinct().ToArray(); break;
                    case "Replace":
                        var indexReplace = int.Parse(command[1]);
                        if (indexReplace<0||indexReplace>=wordsArray.Length)
                        {
                            Console.WriteLine("Invalid input!");
                            break;
                        }
                        var wordForReplace = command[2];
                        wordsArray[indexReplace] = wordForReplace;
                        break;
                    default: Console.WriteLine("Invalid input!");break;
                }
            }
            Console.WriteLine(string.Join(", ", wordsArray));
        }
    }
}
