using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();
            string textFirst = input[0];
            string textSecond = input[1];
            int lettersOfShorterText = Math.Min(textFirst.Length, textSecond.Length);
            var charFirstText = textFirst.Select(x => (int)x).ToArray();
            var charSecondText = textSecond.Select(x => (int)x).ToArray();
            double sum = 0.0;
            for (int i = 0; i < lettersOfShorterText; i++)
            {
                sum += (charFirstText[i] * charSecondText[i]);
            }
            if (textFirst.Length == textSecond.Length)
            {
                Console.WriteLine($"{sum:f0}");
                return;
            }
            int moreLetters = Math.Abs(textFirst.Length - textSecond.Length);
            if (textFirst.Length > textSecond.Length)
            {
                Array.Reverse(charFirstText);
                for (int i = 0; i < moreLetters; i++)
                {
                    sum += charFirstText[i];
                }
                Console.WriteLine($"{sum:f0}");
            }
            else
            {
                Array.Reverse(charSecondText);
                for (int i = 0; i < moreLetters; i++)
                {
                    sum += charSecondText[i];
                }
                Console.WriteLine($"{sum:f0}");
            }

        }
    }
}
