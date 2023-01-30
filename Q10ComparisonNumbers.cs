using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    internal class Q10ComparisonNumbers
    {
        public static void ComparisonNumbers()
        {
            Console.WriteLine("Enter a 1st number - :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a 2nd number - :");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a 3rd number - :");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("bigger number is " + a);
            }
            else if (b > c)
            {
                Console.WriteLine(" bigger number is  " + b);
            }
            else
            {
                Console.WriteLine("biggger number is - : " +c);
            }

        }
    }
}
