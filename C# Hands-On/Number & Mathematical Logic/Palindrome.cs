using System;
using System.Collections.Generic;
using System.Text;

namespace Number___Mathematical_Logic
{
    public class Palindrome
    {
        public static void CheckPalindrome()
        {
            Console.WriteLine("To check the given number is palindrome\n");

            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int originalNum = num;
            int reversedNum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                reversedNum = (reversedNum * 10) + digit;
                num /= 10;
            }
            if (originalNum == reversedNum)
            {
                Console.WriteLine($"{originalNum} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{originalNum} is not a palindrome.");
            }
        }
    }
}
