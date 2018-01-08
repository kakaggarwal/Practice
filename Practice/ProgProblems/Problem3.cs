using System;

namespace Practice.ProgProblems
{
    // Largest Prime Factor of 600851475143 
    class Problem3
    {
        public static void Solution()
        {
            Console.WriteLine("Enter N: ");
            long n = Convert.ToInt64(Console.ReadLine());

            //long number = 600851475143;
            long max = 0;
            bool prime;

            for (long i = n; i > 1; i--)
            {
                if (i < n && i > (n / 2))
                {
                    i = n / 2;
                }

                prime = true;

                for (long j = 2; j <= i/2; j++)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                        break;
                    }
                }

                if (prime && n % i == 0)
                {
                    max = i;
                    break;
                }
            }

            Console.WriteLine(max);

            //////////////////////////////////////////////////////

            while (n % 2 == 0)
            {
                n /= 2;
            }

            if (n == 1)
            {
                Console.WriteLine(2);
            }
            else
            {
                int i = 3;

                while (n > 1 && i <= Math.Sqrt(n))
                {
                    if (n % i == 0)
                    {
                        n /= i;
                    }
                    else
                    {
                        i += 2;
                    }
                }

                if (n == 1)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(n);
                }
            }
        }
    }
}
