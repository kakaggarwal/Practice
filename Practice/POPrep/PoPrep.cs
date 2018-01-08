using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.POPrep
{
    class PoPrep
    {
        public static void Choice()
        {
            int choice = 0;

            Console.WriteLine("********Menu************");
            Console.WriteLine("1. Study");
            Console.WriteLine("2. Test");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Enter your choice: ");

            try
            {
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Study();
                        break;
                    case 2:
                        Test();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Wrong Choice!!!");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occured Exception: {0} at {1}", ex.Message, ex.StackTrace);
            }
        }

        public static void Study()
        {
            int choice = 0;

            Console.WriteLine("*************Sub-Menu**************");
            Console.WriteLine("1. Squares");
            Console.WriteLine("2. Cubes");
            Console.WriteLine("3. Tables");
            Console.WriteLine("4 Factorials");
            Console.WriteLine("9. Go back to previous menu");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Enter your choice: ");

            try
            {
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Squares();
                        break;
                    case 2:
                        Cubes();
                        break;
                    case 3:
                        Tables();
                        break;
                    case 4:
                        Factorials();
                        break;
                    case 9:
                        Choice();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Wrong Choice!!!");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0} occured at {1}", ex.Message, ex.StackTrace);
            }
        }

        public static void Squares()
        {
            int upto = 30;

            try
            {
                if (upto >= 1)
                {
                    Console.WriteLine("Squares are: ");

                    for (int i = 1; i <= upto; i++)
                    {
                        Console.WriteLine("Square of {0} is {1}", i, (i * i));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0} occured at {1}", ex.Message, ex.StackTrace);
            }
        }

        public static void Cubes()
        {
            int upto = 30;

            try
            {
                if (upto >= 1)
                {
                    Console.WriteLine("Cubes are: ");

                    for (int i = 1; i <= upto; i++)
                    {
                        Console.WriteLine("Cube of {0} is {1}", i, (i * i * i));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0} occured at {1}", ex.Message, ex.StackTrace);
            }
        }

        public static void Tables()
        {
            int tableOf = 1;

            Console.WriteLine("Table of ??");

            try
            {
                tableOf = Convert.ToInt32(Console.ReadLine());

                if (tableOf >= 1)
                {
                    for (int i = 1; i < 11; i++)
                    {
                        Console.WriteLine("{0} x {1} = {2}", tableOf, i, (tableOf * i));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0} occured at {1}", ex.Message, ex.StackTrace);
            }
        }

        public static void Factorials()
        {
            Console.WriteLine("Factorials 1 - 15 are:");

            for (int i = 1; i < 16; i++)
            {
                Console.WriteLine("Factorial of {0} = {1}", i, Factorial(i));
            }
        }

        public static int Factorial(int value)
        {
            if (value == 0)
            {
                return 1;
            }
            else
            {
                return value * Factorial(value - 1);
            }
        }

        public static void Test()
        {
            int choice = 0;

            Console.WriteLine("*************Test Sub-Menu***************");
            Console.WriteLine("1. Squares Test");
            Console.WriteLine("2. Cubes Test");
            Console.WriteLine("3. Tables Test");
            Console.WriteLine("4. Factorial Test");
            Console.WriteLine("9. Go back to previous menu");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Enter your choice: ");

            try
            {
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        SquareTest();
                        break;
                    case 2:
                        CubeTest();
                        break;
                    case 3:
                        TableTest();
                        break;
                    case 4:
                        FactorialTest();
                        break;
                    case 9:
                        Choice();
                        break;
                    case 0:
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0} at {1}", ex.Message, ex.StackTrace);
            }
        }

        public static void SquareTest()
        {
            int randomInt = 0;
            int answer = 0;
            Random randomNumber = new Random();

            Console.WriteLine("Square Test: ");
            Console.WriteLine("Enter any character to exit test anytime.");

            while (true)
            {
                try
                {
                    randomInt = randomNumber.Next(1, 26);

                    Console.WriteLine("Square of {0} is ??", randomInt);

                    answer = Convert.ToInt32(Console.ReadLine());

                    if (answer == (randomInt * randomInt))
                    {
                        Console.WriteLine("Correct!!!");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect!!!. Square of {0} is {1}", randomInt, (randomInt * randomInt));
                    }
                }
                catch (Exception)
                {
                    break;
                }
            }
        }

        public static void CubeTest()
        {
            int randomInt = 0;
            int answer = 0;
            Random randomNumber = new Random();

            Console.WriteLine("Cube Test: ");
            Console.WriteLine("Enter any character to exit test anytime.");

            while (true)
            {
                try
                {
                    randomInt = randomNumber.Next(1, 26);

                    Console.WriteLine("Cube of {0} is ??", randomInt);

                    answer = Convert.ToInt32(Console.ReadLine());

                    if (answer == (randomInt * randomInt * randomInt))
                    {
                        Console.WriteLine("Correct!!!");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect!!!. Square of {0} is {1}", randomInt, (randomInt * randomInt * randomInt));
                    }
                }
                catch (Exception)
                {
                    break;
                }
            }
        }

        public static void TableTest()
        {
            int randomTableOf = 0;
            int randommultiple = 0;
            int answer = 0;

            Random tableof = new Random();
            Random multiple = new Random();

            Console.WriteLine("Table Test: ");
            Console.WriteLine("Enter any character to exit test anytime.");

            while (true)
            {
                try
                {
                    randomTableOf = tableof.Next(1, 26);
                    randommultiple = multiple.Next(1, 11);

                    Console.WriteLine("{0} x {1} = ??", randomTableOf, randommultiple);

                    answer = Convert.ToInt32(Console.ReadLine());

                    if (answer == (randomTableOf * randommultiple))
                    {
                        Console.WriteLine("Correct!!!");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect!!!");
                        Console.WriteLine("{0} x {1} = {2}", randomTableOf, randommultiple, (randomTableOf * randommultiple));
                    }
                }
                catch (Exception)
                {
                    break;
                }
            }
        }

        public static void FactorialTest()
        {
            int answer = 0;
            int correctAnswer = 0;
            int randomInt = 0;
            Random randomNum = new Random(1);

            Console.WriteLine("Factorials Test: ");
            Console.WriteLine("Enter characters to exit the test anytime");

            while (true)
            {
                try
                {
                    randomInt = randomNum.Next(1, 16);

                    Console.WriteLine("Factorial of {0} is ??", randomInt);

                    answer = Convert.ToInt32(Console.ReadLine());
                    correctAnswer = Factorial(randomInt);


                    if (answer == correctAnswer)
                    {
                        Console.WriteLine("correct!!!");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect!!!");
                        Console.WriteLine("Factorial of {0} is {1}", randomInt, correctAnswer);
                    }
                }
                catch (Exception)
                {
                    break;
                }
            }
        }
    }
}
