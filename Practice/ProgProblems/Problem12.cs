using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.ProgProblems
{
    class TriangularNumber
    {
        public int Number { get; set; }
        public int Divisors { get; set; }
    }

    // Highly divisible triangular number
    class Problem12
    {
        public static void Solution()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            List<TriangularNumber> triangles = new List<TriangularNumber>() { new TriangularNumber { Number = 1, Divisors = 1 } };

            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int i = 1;

                while (true)
                {
                    if (i > triangles.Count)
                    {
                        int temp = triangles[i-2].Number + i;

                        int counter = 0;

                        for (int k = 1; k * k <= temp; k++)
                        {
                            if (temp % k == 0)
                            {
                                counter += 2;
                            }
                        }

                        triangles.Add(new TriangularNumber
                        {
                            Number = temp,
                            Divisors = counter
                        });
                    }

                    if (triangles[i - 1].Divisors > n)
                    {
                        break;
                    }

                    i++;
                }

                Console.WriteLine(triangles[i - 1].Number);
            }
        }
    }
}
