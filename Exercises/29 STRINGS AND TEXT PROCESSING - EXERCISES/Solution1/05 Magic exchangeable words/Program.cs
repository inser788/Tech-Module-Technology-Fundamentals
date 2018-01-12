using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Magic_exchangeable_words
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();
            var wordOne = input[0];
            var wordTwo = input[1];
            int lengthOfShorterWord = Math.Min(wordOne.Length, wordTwo.Length);
            var wordOneChar = wordOne.ToCharArray();
            var wordTwoChar = wordTwo.ToCharArray();

            var magicLetters = new Dictionary<char, char>();
            for (int i = 0; i < lengthOfShorterWord; i++)
            {
                if (!magicLetters.ContainsKey(wordOneChar[i]))
                {
                    if (magicLetters.ContainsValue(wordTwo[i]))
                    {
                        Console.WriteLine("false");
                        return;
                    }
                    else
                    {
                        magicLetters.Add(wordOneChar[i], wordTwoChar[i]);
                    }
                }
                else
                {
                    if (!magicLetters.ContainsValue(wordTwo[i]))
                    {
                        Console.WriteLine("false");
                        return;
                    }
                }
            }
            if (wordOne.Length == wordTwo.Length)
            {
                Console.WriteLine("true");
                return;
            }
            int rangeOfBiggerWord = Math.Abs(wordOne.Length - wordTwo.Length);
            if (wordOne.Length > wordTwo.Length)
            {
                Array.Reverse(wordOneChar);
                for (int i = 0; i < rangeOfBiggerWord; i++)
                {
                    if (!magicLetters.ContainsKey(wordOneChar[i]))
                    {
                        Console.WriteLine("false");
                        return;
                    }

                }
                Console.WriteLine("true");
            }
            else
            {
                Array.Reverse(wordTwoChar);
                for (int i = 0; i < rangeOfBiggerWord; i++)
                {
                    if (!magicLetters.ContainsValue(wordTwoChar[i]))
                    {
                        Console.WriteLine("false");
                        return;
                    }

                }
                Console.WriteLine("true");
            }


        }
    }
}
