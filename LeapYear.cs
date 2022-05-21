using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class LeapYear
    {
        public static void PrintLeapYear()
        {
            Console.WriteLine("Please enter the year");
            int year = Convert.ToInt32(Console.ReadLine());
           // string year = Console.ReadLine();
            //Console.WriteLine(year.Length);
            // int i = username.Length;
            if (((year % 4 == 0 && year % 100 != 0)) || (year % 400 == 0))
            {
                Console.WriteLine("{0} is a leap year",year);
            }
            else 
            {
                Console.WriteLine("{0} is not a leap year",year);
            }
        }
    }
}
