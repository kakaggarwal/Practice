using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    static class CalExponent
    {
        public static int Exponent(int value, int power)
        {
            int result = 1;

            for (int i = 0; i < power; i++)
            {
                result = result * value;
            }

            return result;
        }
    }
}
