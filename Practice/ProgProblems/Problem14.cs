using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.ProgProblems
{
    // Longest Collatz sequence
    class Problem14
    {
        public static void Solution()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            List<int> collatzNumbers = new List<int>();

            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                if (n > collatzNumbers.Count)
                {
                    for (int i = collatzNumbers.Count + 1; i <= n; i++)
                    {
                        int j = i;
                        int counter = 0;

                        while (j > 1)
                        {
                            if (j % 2 == 0)
                            {
                                j = j / 2;
                            }
                            else
                            {
                                j = 3 * j + 1;
                            }

                            counter++;
                        }

                        collatzNumbers.Add(counter);
                    } 
                }

                int max = 0;
                int index = 0;

                for (int i = 0; i < n; i++)
                {
                    if (collatzNumbers[i] >= max)
                    {
                        max = collatzNumbers[i];
                        index = i + 1;
                    }
                }

                Console.WriteLine(index);
            }
        }
    }
}
