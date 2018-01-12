using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {

            var dictionary = new SortedDictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine().Trim();
            while (input != "end")
            {
                var listOfData = input.Split(new char[] { '=', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var ipAdress = listOfData[1];
                var userName = listOfData[5];
                var counter = 1;
                if (!dictionary.ContainsKey(userName))
                {
                    dictionary[userName] = new Dictionary<string, int>();
                }
                if (!dictionary[userName].ContainsKey(ipAdress))
                {
                    dictionary[userName][ipAdress] = counter;
                }
                else
                {
                    dictionary[userName][ipAdress]++;
                }
                input = Console.ReadLine().Trim();

                

            }
            foreach (var user in dictionary)
            {
                Console.WriteLine(user.Key+":");
                Console.Write(string.Join(", ", user.Value.Select(x => x.Key + " => " + x.Value)));
                Console.WriteLine(".");
            }
        }


    }
}
