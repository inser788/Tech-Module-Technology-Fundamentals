using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int count = 0;
            string word = string.Empty;
            for (int i = 0; i < numberOfLines; i++)
            {
                string line = Console.ReadLine();
                if (line.Contains('('))
                {
                    count++;
                    word += '(';
                    continue;

                }
                else if (line.Contains(')'))
                {
                    count++;
                    word += ')';
                    continue;


                }
            }
            if (word.StartsWith(")")||word.EndsWith("("))
            {
                Console.WriteLine("UNBALANCED");
                return;
            }
            if (count % 2 == 0)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
            
        }
    }
}
