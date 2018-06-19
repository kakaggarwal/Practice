using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.ProgProblems
{
    // Large sum
    class Problem13
    {
        public static void Solution()
        {
            try
            {
                int t = Convert.ToInt32(Console.ReadLine());
                string[] n = new string[t];

                for (int a0 = 0; a0 < t; a0++)
                {
                    n[a0] = Console.ReadLine();
                }

                ulong result = 0;

                foreach (var item in n)
                {
                    result += Convert.ToUInt64(item.Substring(0, 14));
                }

                Console.WriteLine(result.ToString().Substring(0, 10));
            }
            catch (Exception ex)
            {
                //string fault = ex.Message;
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
