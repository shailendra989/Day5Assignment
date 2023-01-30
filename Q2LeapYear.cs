using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    internal class Q2LeapYear
    {
        public static void LeapYeaR()
        {
            Console.WriteLine("Enter a year");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(year);

            if(year % 100 == 0 && year % 4 == 0)
            {
                  Console.WriteLine("This is a leap year");
             }
            else if(year % 4 == 0)
            {
                Console.WriteLine("This is a leap year");
            }
            else
            {
                Console.WriteLine("This is not a leap year");
            }  
        }

    }
}
