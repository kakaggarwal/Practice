using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.ProgProblems
{
    // Special Pythagorean triplet
    class Problem9
    {
        public static void Solution()
        {
            try
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int result = -1;
                int c = 0;

                for (int a = 1; a < n / 3; a++)
                {
                    for (int b = a + 1; b < n / 2; b++)
                    {
                        c = n - a - b;

                        if (a + b > c && a + c > b && b + c > a)
                        {
                            result = a * b * c;
                        }
                    }
                }

                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                string fault = ex.Message;
            }
        }
    }
}
