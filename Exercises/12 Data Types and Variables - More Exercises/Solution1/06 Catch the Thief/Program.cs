using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Catch_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeralType = Console.ReadLine();
            int countOfIds = int.Parse(Console.ReadLine());
            sbyte maxValueSbyte=sbyte.MinValue;
            int maxValueInt = int.MinValue;
            long maxValueLong = long.MinValue;
            for (int i = 0; i < countOfIds; i++)
            {
                long id = long.Parse(Console.ReadLine());
                switch (numeralType)
                {
                    case "sbyte":
                        if (id>=sbyte.MinValue&&id<=sbyte.MaxValue)
                        {
                            if (id>maxValueSbyte)
                            {
                                maxValueSbyte = (sbyte)id;
                            }
                        }break;
                    case "int":
                        if (id >= int.MinValue && id <= int.MaxValue)
                        {
                            if (id > maxValueInt)
                            {
                                maxValueInt = (int)id;
                            }
                        }
                        break;
                    case "long":
                        if (id >= long.MinValue && id <= long.MaxValue)
                        {
                            if (id > maxValueLong)
                            {
                                maxValueLong = id;
                            }
                        }
                        break;
                }

            }
            switch (numeralType)
            {
                case "sbyte": Console.WriteLine(maxValueSbyte);break;
                case "int": Console.WriteLine(maxValueInt); break;
                case "long": Console.WriteLine(maxValueLong); break;

            }

        }
    }
}
