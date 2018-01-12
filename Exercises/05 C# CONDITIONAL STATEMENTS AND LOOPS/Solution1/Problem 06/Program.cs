using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayOfWeek = Console.ReadLine();
            int agePerson = int.Parse(Console.ReadLine());

            switch (dayOfWeek)
            {
                case "Weekday":
                    if (agePerson>=0 && agePerson<=18||agePerson>64 && agePerson<=122)
                    {
                        Console.WriteLine("12$");
                    }
                    else if (agePerson>18&& agePerson<=64)
                    {
                        Console.WriteLine("18$");
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;
                case "Weekend":
                    if (agePerson >= 0 && agePerson <= 18 || agePerson > 64 && agePerson <= 122)
                    {
                        Console.WriteLine("15$");
                    }
                    else if (agePerson > 18 && agePerson <= 64)
                    {
                        Console.WriteLine("20$");
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;
                case "Holiday":
                    if (agePerson >= 0 && agePerson <= 18)
                    {
                        Console.WriteLine("5$");
                    }
                    else if (agePerson > 18 && agePerson <= 64)
                    {
                        Console.WriteLine("12$");
                    }
                    else if (agePerson > 64 && agePerson <= 122)
                    {
                        Console.WriteLine("10$");
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;
            }
        }
    }
}
