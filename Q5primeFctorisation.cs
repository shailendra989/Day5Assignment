using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    internal class Q5Primefactorisation
    {
        public static void Primefactorisation()
        {
            Console.WriteLine("Enter Number - : ");
            int m = Convert.ToInt32(Console.ReadLine());
             for(int i =2; i <= m; i++)
            {
              while(m%i==0)
                {
                    m = m / i;
                    Console.WriteLine(i);
                }
            }
        }
    }
}
