using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06_Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var rawInput = Console.ReadLine();
            var pattern = @"(?<=^|[ \/\\\(\)])[A-Za-z][A-Za-z\d_]{2,24}(?=$|[ \/\\\(\)])";
            var matches = Regex.Matches(rawInput, pattern);
            var listOfUsers = matches.Cast<Match>().Select(a => a.Value).ToList();
            int listLenth = listOfUsers.Count;
            int maxSum = 0;
            var index = -1;
            var listOfMax = new List<string>();
            for (int i = 0; i < listLenth-1; i++)
            {
                var currentSum = listOfUsers[i].Length + listOfUsers[i + 1].Length;
                if (currentSum>maxSum)
                {
                    maxSum = currentSum;
                    index = i;
                }
            }
            Console.WriteLine(listOfUsers[index]);
            Console.WriteLine(listOfUsers[index+1]);

        }
    }
}
