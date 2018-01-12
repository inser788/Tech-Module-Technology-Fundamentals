using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Exerceises
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            var students = new Student[numberOfStudents];
            for (int i = 0; i < numberOfStudents; i++)
            {
                var input = Console.ReadLine().Split().ToArray();
                students[i] = new Student
                {
                    Name = input.First(),
                    Grades = input.Skip(1).Select(double.Parse).ToArray()

                };
            }
            var orderedStudents = students.Where(st => st.AverageGrades >= 5).OrderBy(n => n.Name).ThenBy(avg => -avg.AverageGrades).ToArray();
            foreach (var student in orderedStudents)
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrades:f2}");
            }
        }
    }
}
