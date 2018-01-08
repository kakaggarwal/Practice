using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.ProgProblems
{
    // Smallest Positive Multiple of numbers from 1 to 20
    class Problem5
    {
        public static void Solution()
        {
            try
            {
                Console.WriteLine("Enter N: ");
                int n = Convert.ToInt32(Console.ReadLine());

                long result = 1;

                while (true)
                {
                    int i = 2;

                    for (; i < 21; i++)
                    {
                        if (result % i != 0)
                        {
                            break;
                        }
                    }

                    if (i == 21)
                    {
                        break;
                    }

                    result++;
                }                

                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
