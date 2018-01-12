using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());
            string word = string.Empty;
            for (int i = 0; i < lines; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                int newSymbol = symbol + key;
                word += (char)newSymbol;
            }
            Console.WriteLine(word);
        }
    }
}
