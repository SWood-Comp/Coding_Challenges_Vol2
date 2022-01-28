using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges_Vol2
{
    class _3_OddorEven
    {
        // Program to take a number input and outputs "even" for even numbers and "odd" for odd numbers.
        static void Main()
        {
            Console.WriteLine("Odd or Even...");
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            Boolean isEven;

            if (num / 2 == 0)
                isEven = true;
            else
                isEven = false;

            // second IF statement (selection based on criteria)
            if (isEven == true)
            {
                Console.WriteLine("Number {0} is Even.", num);
            }
            else
            {
                Console.WriteLine("Number {0} is Even.", num);
            }

        }
    }
}
