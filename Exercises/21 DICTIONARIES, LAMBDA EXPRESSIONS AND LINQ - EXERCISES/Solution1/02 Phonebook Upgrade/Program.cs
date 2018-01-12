using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOk = true;
            var phoneBook = new SortedDictionary<string, string>();

            while (isOk)
            {
                var command = Console.ReadLine().Split().ToList();
                var operation = command[0];
                switch (operation)
                {
                    case "A": GetAddingNameAndNumber(phoneBook, command); break;
                    case "S": GetSearchingName(phoneBook, command); break;
                    case "ListAll":GetAllContactsAndNumbers(phoneBook);break;
                    case "END": return;

                }
            }
        }

         static void GetAllContactsAndNumbers(SortedDictionary<string, string> phoneBook)
        {
            foreach (var name in phoneBook)
            {
                Console.WriteLine($"{name.Key} -> {name.Value}");
            }
        }

        static void GetSearchingName(SortedDictionary<string, string> phoneBook, List<string> command)
        {
            var userName = command[1];
            if (phoneBook.ContainsKey(userName))
            {
                Console.WriteLine($"{userName} -> {phoneBook[userName]}");
            }
            else
            {
                Console.WriteLine($"Contact {userName} does not exist.");
            }
        }

        static void GetAddingNameAndNumber(SortedDictionary<string, string> phoneBook, List<string> command)
        {
            var userName = command[1];
            var userPhone = command[2];
            if (phoneBook.ContainsKey(userName))
            {
                phoneBook[userName] = userPhone;
            }
            else
            {
                phoneBook.Add(userName, userPhone);
            }
        }
    }
}
