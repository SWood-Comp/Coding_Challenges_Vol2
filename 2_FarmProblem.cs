using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges_Vol2
{
    class _2_FarmProblem
    {
        // Program that will calculate how many legs exist on a farm
        // where you have chickens (2 legs), cows (4 legs), pigs (4 legs) and farm workers (2 legs) on your farm. 
        // The user should enter how many of each they have.
        // Return the total number of legs on your farm.

        static void Main()
        {
            int chickens, cows, pigs, workers;
            Console.Write("Please enter the number of chickens: ");
            chickens = int.Parse(Console.ReadLine());
            Console.Write("Please enter the number of cows: ");
            cows = int.Parse(Console.ReadLine());
            Console.Write("Please enter the number of pigs: ");
            pigs = int.Parse(Console.ReadLine());
            Console.Write("Please enter the number of workers: ");
            workers = int.Parse(Console.ReadLine());

            int totalLegs = 0;

            totalLegs = (chickens * 2) + (cows * 4) + (pigs * 4) + (workers * 2);

            Console.WriteLine("There are {0} legs on your farm", totalLegs);

        }
    }
}
