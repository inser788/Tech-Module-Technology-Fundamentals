using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
             var separators = new char[] { ' ', '.', '!', '?', ',' };
             var text = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToArray();
             var palindromeWords = new List<string>();
             foreach (var item in text)
             {
            
             string reversedItem = new string(item.ToCharArray().Reverse().ToArray());
                 int result = string.CompareOrdinal(item, reversedItem);
                 if (result==0)
                 {
                     palindromeWords.Add(item);
                 }
             }
             var myWords = palindromeWords.OrderBy(x => x).Distinct().ToList();
             Console.WriteLine(string.Join(", ",myWords));
            
            
            }
            
        }
    }
}
