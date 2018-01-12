using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Hogwarts_Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());

            var listOfAllStudents = new Dictionary<string, List<string>>();
            listOfAllStudents.Add("Gryffindor", new List<string>());
            listOfAllStudents.Add("Slytherin", new List<string>());
            listOfAllStudents.Add("Ravenclaw", new List<string>());
            listOfAllStudents.Add("Hufflepuff", new List<string>());


            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] inputLine = Console.ReadLine()
                    .Split()
                    .ToArray();
                char firstInitial = inputLine.First().ToCharArray().First();
                char secondInitial = inputLine.Last().ToCharArray().First();

                var firstSumChars = inputLine.First().ToCharArray().Sum(x => x);
                var secondSumChars = inputLine.Last().ToCharArray().Sum(x => x);
                var sumTotal = firstSumChars + secondSumChars;
                int remeinder = sumTotal % 4;
                string facNumber = sumTotal + "" + firstInitial + secondInitial;
                switch (remeinder)
                {
                    case 0:
                        listOfAllStudents["Gryffindor"].Add(facNumber);
                        Console.WriteLine($"Gryffindor {facNumber}");
                        break;
                    case 1:
                        listOfAllStudents["Slytherin"].Add(facNumber);
                        Console.WriteLine($"Slytherin {facNumber}");
                        break;
                    case 2:
                        listOfAllStudents["Ravenclaw"].Add(facNumber);
                        Console.WriteLine($"Ravenclaw {facNumber}");
                        break;
                    case 3:
                        listOfAllStudents["Hufflepuff"].Add(facNumber);
                        Console.WriteLine($"Hufflepuff {facNumber}");
                        break;
                }
            }
            Console.WriteLine();
            foreach (var item in listOfAllStudents)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count()}");
            }
        }
    }
}
