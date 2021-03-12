using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        enum Day1 { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
        enum Day2 { Monday = 1, Tuesday = 2, Wednesday = 3, Thursday = 4, Friday = 5, Saturday = 6, Sunday = 7 };
        static void Main(string[] args)
        {
            Day1 selectedDay1 = Day1.Monday;

            if (selectedDay1 == Day1.Saturday || selectedDay1 == Day1.Sunday)
            {
                Console.WriteLine("you chose weekend");
            }
            else
            {
                Console.WriteLine("you chose weekdays");
            }

            //
            int selectedDay2 = (int)Day2.Monday;

            if (selectedDay2 == (int)Day2.Saturday || selectedDay2 == (int)Day2.Sunday)
            {
                Console.WriteLine("you chose weekend");
            }
            else
            {
                Console.WriteLine("you chose weekdays");
            }

            Console.ReadLine();
        }
    }
}
