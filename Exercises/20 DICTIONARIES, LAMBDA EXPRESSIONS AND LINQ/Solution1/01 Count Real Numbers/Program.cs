using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var realNumbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            var dictionary = new SortedDictionary<double, int>();
            foreach (var num in realNumbers)
            {
                dictionary[num] = 0;
            }
            foreach (var num in realNumbers)
            {
                dictionary[num]++;
            }
            foreach (var item in dictionary.Keys)
            {
                Console.WriteLine($"{item} -> {dictionary[item]}");
            }
        }
    }
}
