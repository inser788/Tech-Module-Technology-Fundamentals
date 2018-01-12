using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            string[] dayNames = { "Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday" };
            if (day>0&&day<=7)
            {
                Console.WriteLine(dayNames[day - 1]);

            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
