using System;
using System.Collections.Generic;
using System.Text;

namespace Number___Mathematical_Logic
{
    public class Sum_of_Even_and_odd_digit
    {
        public static void SumEvenOdd()
        {
            Console.WriteLine("To find the even digit sum and odd digit sum seperatly in number\n");

            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                if (digit % 2 == 0)
                {
                    evenSum += digit;
                }
                else
                {
                    oddSum += digit;
                }
                num /= 10;
            }
            Console.WriteLine($"Sum of even digits: {evenSum}");
            Console.WriteLine($"Sum of odd digits: {oddSum}");
        }
    }
}
