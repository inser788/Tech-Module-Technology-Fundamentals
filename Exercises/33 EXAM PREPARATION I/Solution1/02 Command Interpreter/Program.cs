using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Command_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            while (true)
            {
                var commandLine = Console.ReadLine();
                if (commandLine == "end")
                    break;
                var tokensFromCommand = commandLine.Split(' ');
                var commandName = tokensFromCommand.First();
                switch (commandName)
                {
                    case "reverse":
                        ReverseList(tokensFromCommand, input);
                        break;
                    case "sort":
                        SortList(tokensFromCommand, input);
                        break;
                    case "rollLeft":
                        RollLeftList(tokensFromCommand, input);
                        break;
                    case "rollRight":
                        RightRollList(tokensFromCommand, input);
                        break;

                }
            }
        }

        static void RightRollList(string[] tokensFromCommand, List<string> input)
        {
            throw new NotImplementedException();
        }

         static void RollLeftList(string[] tokensFromCommand, List<string> input)
        {
            throw new NotImplementedException();
        }

         static void SortList(string[] tokensFromCommand, List<string> input)
        {
            throw new NotImplementedException();
        }

        static void ReverseList(string[] tokensFromCommand, List<string> input)
        {
            var startIndex = int.Parse(tokensFromCommand[2]);
            var count = int.Parse(tokensFromCommand[4]);
            if (IsValidRange(input,startIndex,count))
            {
                ReverseList(input, startIndex, count);
            }
        }

        static void ReverseList(List<string> input, int startIndex, int count)
        {
            var endIndex = startIndex + count - 1;
            while (startIndex<endIndex)
            {
                var oldValue = input[startIndex];
                input[startIndex] = input[endIndex];
                input[endIndex] = oldValue;
                endIndex--;
                startIndex++;
            }
        }

        static bool IsValidRange(List<string> input,int startIndex, int count)
        {
            if (startIndex < 0)
                return false;
            if (count < 0)
                return false;
            if (startIndex + count >= input.Count - 1)
                return false;
            return true;
        }
    }
}
