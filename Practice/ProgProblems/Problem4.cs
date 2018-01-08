using System;
using System.Linq;

namespace Practice.ProgProblems
{
    // Largest Palindrom from product of 2 3-digit numbers.
    class Problem4
    {
        public static void Solution()
        {
            Console.WriteLine("Enter N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            bool flag = true;

            for (int i = n; i > 101100 && flag; i--)
            {
                for (int j = 999; j > 99; j--)
                {
                    if (i % j == 0 && (i / j) / 1000 == 0)
                    {
                        if (i.ToString().Equals(String.Join("", i.ToString().Reverse())))
                        {
                            Console.WriteLine(i);
                            flag = false;
                            break;
                        }
                    }
                }
            }

            

            //int max = 0;
            //int temp = 0;

            //for (int i = 999; i > 99; i--)
            //{
            //    for (int j = 999; j > 99; j--)
            //    {
            //        temp = i * j;

            //        if (temp.ToString().Equals(String.Join("", temp.ToString().Reverse())))
            //        {
            //            if (temp < n && temp > max)
            //            {
            //                max = temp;
            //            }
            //        }
            //    }
            //}

            //Console.WriteLine(max);
        }
    }
}
