using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _10_Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
                int centuries = int.Parse(Console.ReadLine());
                int years = centuries * 100;
                int days = (int)(years * 365.2422);
                int hours = days * 24;
                int minutes = hours * 60;
                long minutess = minutes;
                long seconds = minutess * 60;
           // BigInteger secondss = seconds;
                BigInteger miliSeconds = (BigInteger)seconds * 1000;
                BigInteger microSeconds = (BigInteger)seconds * 1000000;
            
                BigInteger nanoSeconds = (BigInteger)seconds * 1000000000;



                Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes" +
                    $" = {seconds} seconds = {miliSeconds} milliseconds = {microSeconds} microseconds = {nanoSeconds} nanoseconds");
            
        }
    }
}
