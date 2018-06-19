using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.ProgProblems
{
    class Tree
    {
        public int x;
        public Tree l;
        public Tree r;
    };

    class Problem15
    {
        public static void Solve()
        {
            Problem15 prob = new Problem15();

            //Console.WriteLine(prob.solution("abbabba"));
            //Console.WriteLine(prob.solution(100));
            //Console.WriteLine(prob.solution(new int[] { 1, 3, 6, 4, 1, 2 }));
        }

        //public int solution(Tree T)
        //{
            
        //}

        public void Traverse(Tree T)
        {

        }

        //public int solution(string S)
        //{
        //    int count = 0;

        //    for (int i = S.Length - 1; i > 0; i--)
        //    { 
        //        if (S.Substring(0, i) == S.Substring(S.Length - i, i))
        //        {
        //            count = S.Substring(0, i).Length;
        //            break;
        //        }

        //    }

        //    return count;
        //}

        //public int solution(int N)
        //{
        //    if (N < 11)
        //    {
        //        return 1;
        //    }

        //    List<int> nums = new List<int>();

        //    while(N > 0)
        //    {
        //        nums.Add(N % 10);
        //        N = N / 10;
        //    }

        //    int result = 1;
        //    int noOfDigits = nums.Count;
        //    int noOfZeroes = nums.Distinct().Count(q => q == 0);

        //    if (noOfZeroes > 0)
        //    {
        //        result = Factorial(noOfDigits - noOfZeroes) * Factorial(noOfZeroes);
        //    }
        //    else
        //    {
        //        result = Factorial(noOfDigits);
        //    }


        //    foreach (var item in nums.Distinct())
        //    {
        //        result = result / Factorial(nums.Count(q => q == item));
        //    }

        //    return result;
        //}

        public int Factorial(int value)
        {
            if (value == 1)
            {
                return value;
            }

            return value * Factorial(value - 1);
        }

        //public int solution(int[] A)
        //{
        //    List<int> num = A.Where(q => q > 0).Distinct().OrderBy(q => q).ToList();
        //    int i = 1;

        //    if (num.Capacity > 0)
        //    {
        //        if (num.Last() == num.Capacity)
        //        {
        //            i = num.Capacity;
        //        }
        //        else
        //        {
        //            while (i < 100000)
        //            {
        //                if (!A.Contains(i))
        //                {
        //                    break;
        //                }
        //                else
        //                {
        //                    num.Remove(i);
        //                }

        //                i++;
        //            }
        //        }
        //    }

        //    return i;
        //}
    }
}
