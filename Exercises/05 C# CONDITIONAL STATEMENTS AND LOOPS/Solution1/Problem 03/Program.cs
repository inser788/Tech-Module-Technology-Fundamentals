using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int allminutes = hours * 60 + minutes+30;

            int newHours = allminutes / 60;
            int newMinutes = allminutes % 60;

            if (newHours<24)
            {
                Console.WriteLine($"{newHours}:{newMinutes:D2}");
                
            }
            else
            {
                newHours -= 24;
                Console.WriteLine($"{newHours}:{newMinutes:D2}");

            }



        }
    }
}
