using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    internal class Q7SwapNumbers
    {
        public static void SwapTwoNumber()
        {
            int x = 9;
            int y = 5;

            int temp = x;
            x= y;
            y= temp;
            Console.WriteLine(x);
            Console.WriteLine(y);

        }
    }
}
