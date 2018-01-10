using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.ProgProblems
{
    // Summation of primes
    class Problem10
    {
        public static void Solution()
        {
            try
            {
                int t = Convert.ToInt32(Console.ReadLine());
                ISet<int> primes = new HashSet<int>() { 2 };
                long result = 0;
                bool isPrime = true;

                for (int a0 = 0; a0 < t; a0++)
                {
                    int n = Convert.ToInt32(Console.ReadLine());

                    result = 0;

                    if (n > 1)
                    {
                        result = 2;

                        for (int i = 3; i <= n; i += 2)
                        {
                            isPrime = true;

                            foreach (var item in primes)
                            {
                                if (item * item > n)
                                {
                                    break;
                                }

                                if (i != item && i % item == 0)
                                {
                                    isPrime = false;
                                    break;
                                }
                            }

                            //for (int j = 1; j < primes.Count && primes[j] * primes[j] <= n; j++)
                            //{
                            //    if (i != primes[j] && i % primes[j] == 0)
                            //    {
                            //        isPrime = false;
                            //        break;
                            //    }
                            //}

                            if (isPrime)
                            {
                                result += i;
                                primes.Add(i);
                            }
                        }
                    }

                    Console.WriteLine(result);
                }
            }
            catch (Exception ex)
            {
                string fault = ex.Message;
                Console.WriteLine(fault);
            }
        }
    }
}
