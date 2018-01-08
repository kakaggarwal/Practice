using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.ProgProblems
{
    // Find 10001st prime
    class Problem7
    {
        public static void Solution()
        {
            try
            {
                Console.WriteLine("Enter N: ");
                int n = Convert.ToInt32(Console.ReadLine());

                bool isPrime;
                List<int> primes = new List<int> { 2 };

                for (int counter = 3; primes.Count < n; counter += 2)
                {
                    isPrime = true;

                    for (int j = 1; j < primes.Count && primes[j] * primes[j] <= counter; j++)
                    {
                        if (counter % primes[j] == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime)
                    {
                        primes.Add(counter);
                    }
                }

                Console.WriteLine(primes[n - 1]);

                //if (n == 1)
                //{
                //    Console.WriteLine(2);
                //}
                //else
                //{
                //    int counter = 1;
                //    bool isPrime = true;
                //    List<int> primes = new List<int>();

                //    int i = 3;

                //    while (true)
                //    {
                //        isPrime = true;
                //        int j = 3;

                //        foreach (var item in primes)
                //        {
                //            if (i % item == 0)
                //            {
                //                isPrime = false;
                //                break;
                //            }
                //        }

                //        if (isPrime)
                //        {
                //            if (primes.Count > 0)
                //            {
                //                j = primes.Last();
                //            }

                //            for (; j <= i / 2; j += 2)
                //            {
                //                if (i % j == 0)
                //                {
                //                    isPrime = false;
                //                    break;
                //                }
                //            } 
                //        }

                //        if (isPrime)
                //        {
                //            primes.Add(i);
                //            counter++;

                //            if (counter == n)
                //            {
                //                Console.WriteLine(i);
                //                break;
                //            }
                //        }

                //        i += 2;
                //    }
                //}
            }
            catch (Exception ex)
            {
                string fault = ex.Message;
            }
        }
    }
}
