using System;

namespace Practice.ProgProblems
{
    // Sum Square Difference
    class Problem6
    {
        public static void Solution()
        {
            Console.WriteLine("Enter N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            long sumOfSquares = 0;
            long squareOfSum = 0;

            for (int i = 1; i < (n + 1); i++)
            {
                sumOfSquares += i * i;
                squareOfSum += i;
            }

            squareOfSum *= squareOfSum;

            Console.WriteLine(squareOfSum - sumOfSquares);
        }
    }
}
