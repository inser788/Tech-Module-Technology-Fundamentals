using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
             string a = Console.ReadLine();
             int b = Convert.ToInt32(a, 16);
             Console.WriteLine(b);
           // int a = 428591;
           // Console.WriteLine(a);
           // string b = ("0x")+ Convert.ToString(a,16).ToUpper();
           // //string b = ("0x" + b);
           // Console.WriteLine(b);
           // int c = Convert.ToInt32(b, 16);
           // Console.WriteLine(c);
        }
    }
}
