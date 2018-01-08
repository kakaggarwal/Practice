using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class BinToDec
    {
        private int binary;
        private int number;

        public int Binary
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
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }

        public void BinaryToDecimal()
        {
            char choice = 'n';

            do
            {
                Console.Write("Enter the Binary form: ");
                Binary = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; Binary > 0; i++)
                {
                    Number = Number + ((Binary % 10) * CalExponent.Exponent(2, i));
                    Binary = Binary / 10;
                }

                Console.WriteLine("The Decimal equivalent is {0}", Number);

                Number = 0;

                Console.Write("Do you want to continue (Y/N)? ");
                choice = Convert.ToChar(Console.ReadLine());
            } while (choice == 'y' | choice == 'Y');
        }
    }
}