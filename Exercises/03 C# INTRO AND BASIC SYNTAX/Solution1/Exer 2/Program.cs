using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer_2
{
    class Program
    {
        static void Main(string[] args)
        {

            string nameEmployer = Console.ReadLine();
            int ageEmployer = int.Parse(Console.ReadLine());
            int idEmployer = int.Parse(Console.ReadLine());
            double salaryEmployer = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {nameEmployer}");
            Console.WriteLine($"Age: {ageEmployer}");
            Console.WriteLine($"Employee ID: {idEmployer:D8}");
            Console.WriteLine($"Salary: {salaryEmployer:F2}");






        }
    }
}
