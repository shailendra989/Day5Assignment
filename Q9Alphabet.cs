using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    internal class Q9Alphabet
    {
        public static void VowelOrConsonant()
        {
            Console.WriteLine("enter a vowel");
            String m = Console.ReadLine();

            if (m == "a" || m == "i" || m=="e" || m == "o" || m == "u")
            {
                Console.WriteLine("yes it is vowel");
            }
            else if (m == "A" || m == "E" || m == "I" || m == "O" || m == "U")
            {
                Console.WriteLine("yes it is vowel");
            }
            else
            {
                Console.WriteLine("Not a consonant or invalid data");
            }

        }
    }
}
