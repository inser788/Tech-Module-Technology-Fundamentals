using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var result = new List<int>();
            while (true)
            {
                var command = Console.ReadLine().Split().ToList();
                if (command[0] == "Delete")
                {
                    int numberForDelete = int.Parse(command[1]);
                    while (numbers.Contains(numberForDelete)) numbers.Remove(numberForDelete);
                }
                else if (command[0] == "Insert")
                {
                    var numberForInsert = int.Parse(command[1]);
                    var indexForInsert = int.Parse(command[2]);
                    numbers.Insert(indexForInsert, numberForInsert);
                }
                else
                {
                    if (command[0]=="Even")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i]%2==0)
                            {
                                result.Add(numbers[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ",result));
                        return;
                    }
                    else if (command[0] == "Odd")
                    {
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 != 0)
                            {
                                result.Add(numbers[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", result));
                        return;
                    }

                }
            }
        }
    }
}
