using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.ProgProblems
{
    class Problem8
    {
        // Largest product in a series
        public static void Solution()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string num = Console.ReadLine();

            string temp = "";
            int product = 1;
            int maxProduct = 0;

            for (int i = 0; i + k - 1 < n; i++)
            {
                temp = num.Substring(i, k);

                if (!temp.Contains("0"))
                {
                    foreach (var item in temp)
                    {
                        product = product * Convert.ToInt32(item.ToString());
                    }

                    if (product > maxProduct)
                    {
                        maxProduct = product;
                    }

                    product = 1;
                }
            }

            Console.WriteLine(maxProduct);
        }
    }
}
