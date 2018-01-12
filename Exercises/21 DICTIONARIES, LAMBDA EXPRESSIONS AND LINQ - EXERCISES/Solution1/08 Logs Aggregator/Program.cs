using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Logs_Aggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            var listOfUsers = new SortedDictionary<string, SortedDictionary<string, int>>();
            for (int i = 0; i < numberOfLines; i++)
            {
                var currentInput = Console.ReadLine().Split().ToList();
                var ipNumber = currentInput[0];
                var userName = currentInput[1];
                var duration = int.Parse(currentInput[2]);


                if (!listOfUsers.ContainsKey(userName))
                {
                    listOfUsers[userName] = new SortedDictionary<string, int>();
                }
                if (!listOfUsers[userName].ContainsKey(ipNumber))
                {
                    listOfUsers[userName][ipNumber] = duration;
                }
                else
                {
                    listOfUsers[userName][ipNumber] += duration;
                }

            }
            
            foreach (var name in listOfUsers)
            {
                Console.Write($"{name.Key}: ");Console.Write(name.Value.Select(dur => dur.Value).Sum()+" ");
                Console.WriteLine("["+string.Join(", ",name.Value.Select(x => x.Key))+"]");
            }

        }
    }
}
