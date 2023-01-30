using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    internal class Q3CommandLine
    {
        public static void powers()
        {
            Console.WriteLine("value of power");
             int power = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(power);

            for(int i=0;i<power;i++)
            {
              Console.WriteLine(Math.Pow(2,i));
            }

        }
    }
}
