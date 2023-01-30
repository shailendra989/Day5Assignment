using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    internal class Q8OddEven
    {
        public static void  OddEven()
        {
            Console.WriteLine("Enter Number - :");
            int x = Convert.ToInt32(Console.ReadLine());
            
            if(x % 2 == 0 )
            {
                Console.WriteLine("This is even");
            }
            else
            {
                Console.WriteLine("thi is odd");
            }
        }
    }
}
