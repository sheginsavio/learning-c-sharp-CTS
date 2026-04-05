using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Number___Mathematical_Logic
{
    public class Even_odd_zero
    {
        public static void FindEvenOddZero()
        {
            Console.WriteLine("To check number is even or odd or zero\n");

            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine("The number is zero.");
            }
            else if (number % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
        }
    }
}
