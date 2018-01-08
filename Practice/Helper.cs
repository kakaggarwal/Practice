using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Helper
    {
        public void DecimalToBinary()
        {
            string binary = "";
            int number1;
            int number2;

            Console.Write("Enter the number in Decimal format to convert to Binary format: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            number2 = number1;

            while (number1 > 0)
            {
                if (number1 % 2 == 0)
                {
                    binary = "0" + binary;
                }
                else
                {
                    binary = "1" + binary;
                }

                number1 = number1 / 2;
            }

            Console.WriteLine("{0} in Binary format is {1}", number2, binary);
        }

        public void BinaryToDecimal()
        {
            int binary = 0;
            int number = 0;

            Console.Write("Enter the Binary form: ");
            binary = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; binary > 0; i++)
            {
                number = number + ((binary % 10) * Calc.Exponent(2, i));
                binary = binary / 10;
            }

            Console.WriteLine("The Decimal equivalent is {0}", number);
        }

        public static void PalindromeCheck()
        {
            string word;
            
            Console.Write("Enter the number or word to be checked for being palindrome: ");
            word = Console.ReadLine();

            if (word.Equals(StringReverse(word)))
            {
                Console.WriteLine("{0} is a Palindrome", word);
            }
            else
            {
                Console.WriteLine("{0} is not a Palindrome", word);
            }
        }

        public static string StringReverse(string value)
        {
            string reverse = "";

            for (int i = value.Length - 1, j = 0; i >= 0; i--, j++)
            {
                reverse = reverse + value[i];
            }

            return reverse;
        }

        public static void CharASCIICodeOf()
        {
            char character;
            int code;

            Console.Write("Enter the character whise ASCII code is to be found: ");
            character = Convert.ToChar(Console.ReadLine());

            code = Convert.ToInt32(character);
            Console.WriteLine("ASCII Code is: {0}", code);
        }

        public static void ASCIIToCharOf()
        {
            int code = 0;
            char character;

            Console.Write("Enter the ASCII code: ");
            code = Convert.ToInt32(Console.ReadLine());

            character = Convert.ToChar(code);
            Console.WriteLine("Character is: {0}", character);
        }

        public static void CharSeqPrint()
        {
            char character;

            Console.Write("Enter any Character (a to j): ");
            character = Convert.ToChar(Console.ReadLine());

            if (character < 'a' | character > 'j')
            {
                Console.WriteLine("Please enter a character between a to j.");
            }

            Console.Write("Next 4 characters are: ");

            for (int i = 1; i < 5; i++)
            {
                Console.Write("{0}, ", Convert.ToChar(Convert.ToInt32(character) + i));
            }

            Console.WriteLine();
        }

        public static void ConvertDays()
        {
            int totDays = 0;
            int years = 0;
            int weeks = 0;
            int days = 0;

            Console.Write("Enter the days to convert: ");
            totDays = Convert.ToInt32(Console.ReadLine());

            years = totDays / 365;
            totDays = totDays % 365;
            weeks = totDays / 7;
            totDays = totDays % 7;
            days = totDays;

            Console.WriteLine("Years: {0}\nWeeks: {1}\nDays: {2}");
        }

        public static void LargestOfAll()
        {
            int number1;
            int number2;
            int number3;
            int largest;

            Console.WriteLine("Enter the numbers to compare: ");
            Console.Write("Number 1: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 2: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 3: ");
            number3 = Convert.ToInt32(Console.ReadLine());

            if (number1 > number2)
            {
                if (number1 > number3)
                {
                    Console.WriteLine("{0} is the largest", number1);
                }
                else if (number3 > number1)
                {
                    Console.WriteLine("{0} is the largest", number3);
                }
                else
                {
                    Console.WriteLine("{0} is the largest", number1);
                }
            }
            else if (number2 > number1)
            {
                if (number2 > number3)
                {
                    Console.WriteLine("{0} is the largest", number2);
                }
                else if (number3 > number2)
                {
                    Console.WriteLine("{0} is the largest", number3);
                }
                else
                {
                    Console.WriteLine("{0} is the largest", number2);
                }
            }
            else
            {
                if (number1 > number3)
                {
                    Console.WriteLine("{0} is the largest", number1);
                }
                else if (number3 > number1)
                {
                    Console.WriteLine("{0} is the largest", number3);
                }
                else
                {
                    Console.WriteLine("All numbers are equal");
                }
            }
        }

        public static void ConvertTemp()
        {
            double temp;
            int flag;

            Console.WriteLine("Temperture Convertor");
            Console.WriteLine("1. Fahrenheit to Celcius");
            Console.WriteLine("2. Celcius to Fahrenheit");
            Console.Write("State your choice (1/2): ");
            flag = Convert.ToInt32(Console.ReadLine());

            switch (flag)
            {
                case 1:
                    Console.Write("Enter the temperature in Fahrenheit: ");
                    temp = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Temperature in Celcius is {0}", Math.Round((temp - 32) / 1.8, 1));
                    break;
                case 2:
                    Console.Write("Enter temperature in Celcius: ");
                    temp = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Temperature in Fahrenheit is {0}", Math.Round((temp * 1.8) + 32, 1));
                    break;
                default:
                    Console.WriteLine("Wrong choice pal!!");
                    break;
            }
        }

        public static void LeapYearCheck()
        {
            int year;

            Console.Write("Enter the year to be checked for being leap year: ");
            year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0)
            {
                Console.WriteLine("{0} is a Leap year.", year);
            }
            else if (year % 400 == 0)
            {
                Console.WriteLine("{0} is a Leap Year.", year);
            }
            else
            {
                Console.WriteLine("{0} is not a Leap Year", year);
            }
        }

        public static void DescendingArrange()
        {
            List<int> series = new List<int>();

            int max = new int();
            string input = string.Empty;
            int index = new int();

            Console.Write("Enter the series to be arranged in descending order (press + to abort): ");
            
            while (true)
            {
                try
                {
                    input = Console.ReadLine();
                    series.Add(Convert.ToInt32(input));
                }
                catch (Exception)
                {
                    if (input.Equals("+"))
                    {
                        Console.WriteLine("Arranging entered series in Descending order.");
                        break;
                    }
                    else 
                    {
                        Console.WriteLine("Wrong Input!! Enter either an integer or \"+\" to abort");
                        Console.Write("Enter the series: ");
                    }
                }
            }

            for (int i = 0; i < series.Count; i++)
            {
                max = new int();
                index = new int();

                for (int j = i; j < series.Count; j++)
                {
                    if (series[j] > max)
                    {
                        max = series[j];
                        index = j;
                    }
                }

                series[index] = series[i];
                series[i] = max;
            }

            Console.Write("Series in Descending order is: ");

            for (int i = 0; i < series.Count; i++)
            {
                Console.Write("{0}, ", series[i]);
            }

            Console.WriteLine();
        }

        public static void AscendingArrange()
        {
            int max = new int();
            string input = string.Empty;
            int index = new int();
            List<int> series = new List<int>();

            Console.Write("Enter the series to be aranged in ascensing order (press + to end): ");
            while (true)
            {
                try
                {
                    input = Console.ReadLine();
                    series.Add(Convert.ToInt32(input));
                }
                catch (Exception)
                {
                    if (input.Equals("+"))
                    {
                        Console.WriteLine("Arranging the series in Ascending order.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong Input!!! Enter either an integer or \"+\" to abort.");
                        Console.Write("Enter the series: ");
                    }
                }
            }

            for (int i = series.Count - 1; i >= 0; i--)
            {
                max = new int();
                index = new int();

                for (int j = i; j >= 0; j--)
                {
                    if (series[j] > max)
                    {
                        max = series[j];
                        index = j;
                    }
                }

                series[index] = series[i];
                series[i] = max;
            }

            Console.Write("Series in Ascending order is: ");

            for (int i = 0; i < series.Count; i++)
            {
                Console.Write("{0}, ", series[i]);
            }

            Console.WriteLine();
        }

        public static void RightAnglePattern()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("{0}  ", Convert.ToChar(65 + j));
                }

                Console.WriteLine();
            }
        }

        public static void InvertedTrianglePattern() 
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("  ");
                }

                for (int j = 0; j < (7 - (2 * i)); j++)
                {
                    Console.Write("& ");
                }

                for (int j = 0; j < i; j++)
                {
                    Console.Write("  ");
                }

                Console.WriteLine();
            }
        }

        public static void StringToUpper() 
        {
            string word = string.Empty;

            Console.Write("Enter the string to be converted to uppercase: ");
            word = Console.ReadLine();

            if (word.Length < 15)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    switch (word[i])
                    {
                        case 'a':
                            word = word.Replace('a', 'A');
                            break;
                        case 'b':
                            word = word.Replace('b', 'B');
                            break;
                        case 'c':
                            word = word.Replace('c', 'C');
                            break;
                        case 'd':
                            word = word.Replace('d', 'D');
                            break;
                        case 'e':
                            word = word.Replace('e', 'E');
                            break;
                        case 'f':
                            word = word.Replace('f', 'F');
                            break;
                        case 'g':
                            word = word.Replace('g', 'G');
                            break;
                        case 'h':
                            word = word.Replace('h', 'H');
                            break;
                        case 'i':
                            word = word.Replace('i', 'I');
                            break;
                        case 'j':
                            word = word.Replace('j', 'J');
                            break;
                        case 'k':
                            word = word.Replace('k', 'K');
                            break;
                        case 'l':
                            word = word.Replace('l', 'L');
                            break;
                        case 'm':
                            word = word.Replace('m', 'M');
                            break;
                        case 'n':
                            word = word.Replace('n', 'N');
                            break;
                        case 'o':
                            word = word.Replace('o', 'O');
                            break;
                        case 'p':
                            word = word.Replace('p', 'P');
                            break;
                        case 'q':
                            word = word.Replace('q', 'Q');
                            break;
                        case 'r':
                            word = word.Replace('r', 'R');
                            break;
                        case 's':
                            word = word.Replace('s', 'S');
                            break;
                        case 't':
                            word = word.Replace('t', 'T');
                            break;
                        case 'u':
                            word = word.Replace('u', 'U');
                            break;
                        case 'v':
                            word = word.Replace('v', 'V');
                            break;
                        case 'w':
                            word = word.Replace('w', 'W');
                            break;
                        case 'x':
                            word = word.Replace('x', 'X');
                            break;
                        case 'y':
                            word = word.Replace('y', 'Y');
                            break;
                        case 'z':
                            word = word.Replace('z', 'Z');
                            break;
                        default:
                            break;
                    }
                }
            }
            else
            {
                word = word.Replace('a', 'A');
                word = word.Replace('b', 'B');
                word = word.Replace('c', 'C');
                word = word.Replace('d', 'D');
                word = word.Replace('e', 'E');
                word = word.Replace('f', 'F');
                word = word.Replace('g', 'G');
                word = word.Replace('h', 'H');
                word = word.Replace('i', 'I');
                word = word.Replace('j', 'J');
                word = word.Replace('k', 'K');
                word = word.Replace('l', 'L');
                word = word.Replace('m', 'M');
                word = word.Replace('n', 'N');
                word = word.Replace('o', 'O');
                word = word.Replace('p', 'P');
                word = word.Replace('q', 'Q');
                word = word.Replace('r', 'R');
                word = word.Replace('s', 'S');
                word = word.Replace('t', 'T');
                word = word.Replace('u', 'U');
                word = word.Replace('v', 'V');
                word = word.Replace('w', 'W');
                word = word.Replace('x', 'X');
                word = word.Replace('y', 'Y');
                word = word.Replace('z', 'Z');
            }

            Console.WriteLine("string in uppercase is {0}", word);
        }

        public static void CountString()
        {
            string sentence;

            Console.Write("Enter the string whose characters to count: ");
            sentence = Console.ReadLine();

            Console.WriteLine("No. of Characters: {0}", sentence.Length);
        }
    }
}
