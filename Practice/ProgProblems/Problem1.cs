using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice.ProgProblems
{
    // Multiples of 3 or 5
    class Problem1
    {
        public static void Solution()
        {
            Console.WriteLine("Enter N: ");
            int n = Convert.ToInt32(Console.ReadLine());


            long result = SumDivisbleBy(3, (n - 1)) + SumDivisbleBy(5, (n - 1)) - SumDivisbleBy(15, (n - 1));

            Console.WriteLine(result);
        }

        private static int SumDivisbleBy(int n, int p)
        {
            return n * (p / n) * ((p / n) + 1) / 2;
        }
    }
}
