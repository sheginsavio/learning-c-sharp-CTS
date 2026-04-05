using System;
using System.Collections.Generic;
using System.Text;

namespace Number___Mathematical_Logic
{
    public class Swap_without_third_variable
    {
        public static void Swap()
        {
            Console.WriteLine("To swap number without third variable\n");
            Console.WriteLine("Enter the first number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Befor Swapping:");
            Console.WriteLine("a: "+a);
            Console.WriteLine("b: "+b);

            a = a ^ b;
            b = a ^ b;
            a = a ^ b;

            Console.WriteLine("After Swapping:");
            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);

        }
    }
}
