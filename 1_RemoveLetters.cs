using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges_Vol2
{
    class _1_RemoveLetters
    {
        // Program to removes the first and last characters from a string. E.g.  “Hello” = “ell”

        static void Main()
        {
            Console.Write("Please enter a string to work with: ");
            string userString = Console.ReadLine();

            string newString = userString.Substring(1, userString.Length - 2);

            Console.WriteLine("New string is: {0}", newString);
        }
    }
}
