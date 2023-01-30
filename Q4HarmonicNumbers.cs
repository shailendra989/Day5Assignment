using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    internal class Q4HarmonicNumbers
    {
        public static void harmonic()
        {
            Console.WriteLine("Writtern decimal no.");
            int decimalNO = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(decimalNO);
            for (double i = 1; i < decimalNO; i++)
            {
                Console.WriteLine(1 / i);
            }
        }
    }
}
