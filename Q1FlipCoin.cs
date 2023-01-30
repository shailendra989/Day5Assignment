using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Assignment
{
    internal class Q1FlipCoin
    {
        public static void flipCoin()
        {
            double head = 0;
            double tail = 0;
            Console.WriteLine("Enter your flip times  :");
            int FlipTimes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("fliptimes is - :" + FlipTimes);

           for (int i = 0; i <= FlipTimes; i++)
            { 
              //  FlipTimes++;
                Random random = new Random();
                head = random.Next(0, 2);
                if (head == 0)
                {
                    head++;
                }
                else
                {
                    tail++;
                }
               
           }
            Console.WriteLine(head);
            Console.WriteLine(tail);
            double percent = (head / FlipTimes) * 100;
            Console.WriteLine(percent);
        }
    }
}
