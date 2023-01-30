using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    internal class Q6QuitentReamainder
    {
        public static void QuitentAndRemainder()
        {
            Console.WriteLine("Enter Dividend - :");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter devisor -");
            int N = Convert.ToInt32(Console.ReadLine());

            int D = M / N;
            Console.WriteLine(D);
            int E = M % N;
            Console.WriteLine(E);
        } 
    }
}
