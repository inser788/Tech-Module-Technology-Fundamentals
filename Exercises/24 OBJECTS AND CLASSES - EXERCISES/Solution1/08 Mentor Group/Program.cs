using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        var students=GetStudentsInfo();
        PrintStudentsDatesAndComments(students);
        
    }

    static void PrintStudentsDatesAndComments(Dictionary<string, Student> students)
    {
        foreach (var student in students)
        {
            Console.WriteLine(student.Key);
            Console.WriteLine("Comments:");

            foreach (var comment in student.Value.Comments)
            {
                Console.WriteLine($"- {comment}");
            }
            Console.WriteLine("Dates attended:");

            foreach (var date in student.Value.AppendDates.OrderBy(x=>x))
            {
                Console.WriteLine($"-- {date:dd/MM/yyyy}");
            }
        }
    }

    static Dictionary<string, Student> GetStudentsInfo()
    {

        Dictionary<string, Student> students = GetNameAndDates();
        students = GetCommentsForStudents(students);
        return students.OrderBy(n=> n.Key).ToDictionary(k=>k.Key,v=>v.Value);
        
    }

    static Dictionary<string, Student> GetCommentsForStudents(Dictionary<string, Student> students)
    {
        
        string input = Console.ReadLine();
        while (input!="end of comments")
        {
            var currentInput = input.Split('-').ToList();
            var studentName = currentInput.First();
            var currentComment = currentInput.Skip(1).First();
            if (students.ContainsKey(studentName))
            {
                students[studentName].Comments.Add(currentComment);
            }
            input = Console.ReadLine();
        }
        return students;
    }

    static Dictionary<string, Student> GetNameAndDates()
    {
        var students = new Dictionary<string, Student>();
        string input = Console.ReadLine();
        while (input != "end of dates")
        {
            var currentInput = input.Split().ToList();
            var studentName = currentInput.First();
            if (!students.ContainsKey(studentName))
            {
                students[studentName] = new Student
                {
                    StudentName = studentName,
                    AppendDates = new List<DateTime>()
                };
            }
            if (currentInput.Count > 1)
            {
                var listOfDates = currentInput[1].Split(',').ToList();
                for (int i = 0; i < listOfDates.Count; i++)
                {
                    var currentDate = DateTime.ParseExact(listOfDates[i], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    students[studentName].AppendDates.Add(currentDate);
                }

            }
            input = Console.ReadLine();
        }
        return students;
    }
}
class Student
{
    public string StudentName { get; set; }

    public List<DateTime> AppendDates = new List<DateTime>();

    public List<string> Comments = new List<string>();
}

