using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class DecToBin
    {
        private string binary;
        private int number1;
        private int number2;

        public string Binary
        {
            get
            {
                return binary;
            }
            set
            {
                binary = value;
            }
        }
        public int Number1
        {
            get
            {
                return number1;
            }
            set
            {
                number1 = value;
            }
        }
        public int Number2
        {
            get
            {
                return number2;
            }
            set
            {
                number2 = value;
            }
        }

        public void DecimalToBinary()
        {
            //Console.WriteLine("here");
            char choice = 'n';

            do
            {
                Console.Write("Enter the number in Decimal format to convert to Binary format: ");
                Number1 = Convert.ToInt32(Console.ReadLine());
                Number2 = Number1;

                while (Number1 > 0)
                {
                    if (Number1 % 2 == 0)
                    {
                        Binary = "0" + Binary;
                    }
                    else
                    {
                        Binary = "1" + Binary;
                    }

                    Number1 = Number1 / 2;
                }

                Console.WriteLine("{0} in Binary format is {1}", Number2, Binary);
                Console.Write("Do you want to continue (y/n)? ");
                choice = Convert.ToChar(Console.ReadLine());
                Binary = "";

            } while (choice == 'y' | choice == 'Y');            
        }
    }
}