using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Calc
    {
        public static int SumOf(int value1, int value2)
        {
            int result = 0;

            result = value1 + value2;

            return result;
        }

        public static int ProductOf(int value1, int value2)
        {
            int result = 1;

            result = value1 * value2;

            return result;
        }

        public static int SquareOf(int value)
        {
            int result = 0;

            result = value * value;

            return result;
        }

        public static int CubeOf(int value)
        {
            int result = 0;

            result = value * value * value;

            return result;
        }

        public static int Exponent(int value, int power)
        {
            int result = 1;

            for (int i = 0; i < power; i++)
            {
                result = result * value;
            }

            return result;
        }

        public static double Exponent(double value, double power)
        {
            double result = 1.0;

            for (int i = 0; i < power; i++)
            {
                result = result * value;
            }

            return result;
        }


        public static double Exponent(int value, double power)
        {
            double result = 1.0;

            for (int i = 0; i < power; i++)
            {
                result = result * value;
            }

            return result;
        }

        public static void Solve()
        {
            const double e = 2.71828;
            double result, y;

            Console.Write("Enter value of y: ");
            y = Convert.ToDouble(Console.ReadLine());

            result = 2 - (y * (Exponent(e, (2 * y)))) + (Exponent(4, y));

            Console.WriteLine("The result is {0}", result);
        }

        public static  int FactorialOf(int value)
        {
            if (value == 0)
            {
                return 1;
            }
            else
            {
                return value * FactorialOf(value - 1);
            }
        }

        public static void PrimeCheck()
        {
            int number;
        
            Console.Write("Enter the Number to check for being prime: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine("0 is neither prime nor composite.");
            }
            else if (number  == 1)
            {
                Console.WriteLine("1 is neither prime nor composite.");
            }
            else
            {
                for (int i = 2; i < number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        Console.WriteLine("{0} is not prime.", number);

                        break;
                    }
                }

                Console.WriteLine("{0} is a Prime number.", number);
            }
        }

        public static void Factors()
        {
            int number;

            Console.Write("Enter the number whose factors to be found: ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Factors of {0} are: ", number);

            for (int i = 1; i <= (number / 2); i++)
            {
                if (number % i == 0)
                {
                    Console.Write("{0}, ", i);
                }
            }

            Console.WriteLine("{0}.", number);
        }

        public static void OddorEven() 
        {
            int number;

            Console.Write("Enter the number to check for odd or even: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("{0} is even.", number);
            }
            else
            {
                Console.WriteLine("{0} is odd.", number);
            }
        }

        public static void Fibonacci()
        {
            int number;
            int first = 0;
            int second = 1;

            Console.Write("How many terms of Fibanacci series you want to print? ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Fibnacci Series: ");

            for (int i = 1; i <= number; i++)
            {
                Console.Write("{0}, ", first);

                second = first + second;
                first = second - first;
            }

            Console.WriteLine(".");
        }


    }
}