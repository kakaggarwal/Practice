using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.ProgProblems
{
    // Sum of Even Fibonacci Numbers
    class Problem2
    {
        public static void Solution()
        {
            Console.WriteLine("Enter N: ");
            long n = Convert.ToInt64(Console.ReadLine());

            long result = 0;

            long first = 0;
            long second = 1;
            long current = 0;

            // 4000000
            while(current < n)
            {
                current = first + second;
                first = second;
                second = current;

                if (current % 2 == 0)
                {
                    result += current;
                }
            }

            if (current % 2 == 0)
            {
                result -= current;
            }

            Console.WriteLine(result);
        }
    }
}
