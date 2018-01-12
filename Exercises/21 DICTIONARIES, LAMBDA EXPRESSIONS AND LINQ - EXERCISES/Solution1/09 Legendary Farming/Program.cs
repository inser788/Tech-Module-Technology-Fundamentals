using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOk = true;
            var input = Console.ReadLine().ToLower().Split().ToList();
            var resoursesAndQuantity = new Dictionary<List<string>,List<int>>();
            var listOfQuantity = new List<int>();
            var listOfResourses = new List<string>();
            for (int i = 0; i < input.Count; i+=2)
            {
                listOfQuantity.Add(int.Parse(input[i]));
            }
            for (int i = 1; i < input.Count; i+=2)
            {
                listOfResourses.Add(input[i]);
            }
            
        }
    }
}
