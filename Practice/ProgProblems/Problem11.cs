using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.ProgProblems
{
    class Problem11
    {
        public static void Solution()
        {
            int[][] grid = new int[20][];

            for (int grid_i = 0; grid_i < 20; grid_i++)
            {
                string[] grid_temp = Console.ReadLine().Split(' ');
                grid[grid_i] = Array.ConvertAll(grid_temp, Int32.Parse);
            }

            long max = 0;

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    // Up-Down Direction
                    if (j < 17)
                    {
                        var temp = grid[j][i] * grid[j + 1][i] * grid[j + 2][i] * grid[j + 3][i];

                        if (temp > max)
                        {
                            max = temp;
                        }
                    }

                    // Left-Right Direction
                    if (i < 17)
                    {
                        var temp = grid[i][j] * grid[i + 1][j] * grid[i + 2][j] * grid[i + 3][j];

                        if (temp > max)
                        {
                            max = temp;
                        }
                    }

                    // diagnol direction
                    if (i < 17 && j < 17)
                    {
                        var temp = grid[i][j] * grid[i + 1][j + 1] * grid[i + 2][j + 2] * grid[i + 3][j + 3];

                        if (temp > max)
                        {
                            max = temp;
                        }
                    }

                    if (i > 2 && j < 17)
                    {
                        var temp = grid[i][j] * grid[i - 1][j + 1] * grid[i - 2][j + 2] * grid[i - 3][j + 3];

                        if (temp > max)
                        {
                            max = temp;
                        }
                    }
                }
            }

            Console.WriteLine(max);
        }
    }
}
