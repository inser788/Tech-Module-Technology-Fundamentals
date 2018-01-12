using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04_Cubic_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^([0-9]+)([A-Za-z]+)([^A-Za-z]*)$";
            while (true)
            {
                string lineInput = Console.ReadLine();
                if (lineInput == "Over!")
                    break;
                int messageLength = int.Parse(Console.ReadLine());
                var match = Regex.Match(lineInput, pattern);
                if (!match.Success)
                    continue;
                var receivedMessage = match.Groups[2].Value.ToString();
                if (messageLength != receivedMessage.Length)
                    continue;
                var numbersBeforeMesString = match.Groups[1].Value.ToString().ToCharArray();
                var numbrsBeforeMesNorm = numbersBeforeMesString.Select(x => x - 48).ToArray();
                var listOfDigitsAfter = new List<int>();
                var numbersAfterMesString = match.Groups[3].Value.ToString().ToCharArray();
                for (int i = 0; i < numbersAfterMesString.Length; i++)
                {
                    if (char.IsDigit(numbersAfterMesString[i]))
                    {
                        listOfDigitsAfter.Add(numbersAfterMesString[i] - 48);
                    }
                }

                var receivedMessagetoChar = receivedMessage.ToCharArray();
                StringBuilder cryptMessage = new StringBuilder();
                for (int i = 0; i < numbrsBeforeMesNorm.Length; i++)
                {
                    if (numbrsBeforeMesNorm[i] > receivedMessagetoChar.Length - 1)
                    {
                        cryptMessage.Append(" ");
                    }
                    else
                    {
                        var newChar = receivedMessagetoChar.ElementAt(numbrsBeforeMesNorm[i]);
                        cryptMessage.Append(newChar);
                    }
                }
                for (int i = 0; i < listOfDigitsAfter.Count; i++)
                {
                    if (listOfDigitsAfter[i] > receivedMessagetoChar.Length - 1)
                    {
                        cryptMessage.Append(" ");
                    }
                    else
                    {
                        var newChar = receivedMessagetoChar.ElementAt(listOfDigitsAfter[i]);
                        cryptMessage.Append(newChar);
                    }
                }
                Console.WriteLine($"{receivedMessage} == {cryptMessage.ToString()}");

            }
        }
    }
}
