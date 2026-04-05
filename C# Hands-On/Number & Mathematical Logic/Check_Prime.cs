using System;
using System.Collections.Generic;
using System.Text;

namespace Number___Mathematical_Logic
{
    public class Check_Prime
    {
        public static void IsPrime()
        {
            Console.WriteLine("To check prime or not\n");
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number <= 1)
            {
                Console.WriteLine("The number is not prime.");
                return;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine("The number is not prime.");
                    return;
                }
            }
            Console.WriteLine("The number is prime.");
        }
    }
}
