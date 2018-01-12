using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Letters_Change_Numbers
{
    class Program
    {


        static void Main(string[] args)
        {

            var input = Console.ReadLine().Split(new char[] { ' ','\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            double sumAll = 0.0;
            int a = input.Length;
            for (int i = 0; i < input.Length; i++)
            {
                var currentRow = input[i].ToList();
                char firstLetter = currentRow.First();
                char lastLetter = currentRow.Last();
                currentRow.RemoveAt(0);
                currentRow.RemoveAt(currentRow.Count - 1);
                string stringNumber = string.Empty;
                for (int j = 0; j < currentRow.Count; j++)
                {
                    stringNumber += currentRow[j];
                }
                double number = double.Parse(stringNumber);

                number = LetterBeforeNumber(firstLetter, number);
                number = LetterAfterNumber(lastLetter, number);
                sumAll += number;
            }
            Console.WriteLine($"{sumAll:f2}");
        }

        static double LetterAfterNumber(char lastLetter, double number)
        {
            if (char.IsUpper(lastLetter))
            {
                number = number - (lastLetter - 64);
                return number;
            }
            else
            {
                number = number + (lastLetter - 96);
                return number;
            }
        }

        static double LetterBeforeNumber(char firstLetter, double number)
        {
            if (char.IsUpper(firstLetter))
            {
                number = number / (firstLetter - 64);
                return number;
            }
            else
            {
                number = number * (firstLetter - 96);
                return number;
            }

        }
    }
}
