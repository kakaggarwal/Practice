using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class CharASCIICode
    {
        public static void CharASCIICodeOf()
        {
            char choice = 'n';
            char character;
            int code;

            do
            {
                Console.Write("Enter the character whise ASCII code is to be found: ");
                character = Convert.ToChar(Console.ReadLine());

                code = Convert.ToInt32(character);
                Console.WriteLine("ASCII Code is: {0}", code);

                Console.WriteLine("Do you want to continue (y/n)? ");
                choice = Convert.ToChar(Console.ReadLine());
            } while (choice == 'y' | choice == 'Y');
        }

        public static void ASCIIToCharOf()
        {
            int code = 0;
            char character;
            char choice = 'n';

            do
            {
                Console.Write("Enter the ASCII code: ");
                code = Convert.ToInt32(Console.ReadLine());

                character = Convert.ToChar(code);
                Console.WriteLine("Character is: {0}", character);

                Console.WriteLine("Do you want to continue (y/n)? ");
                choice = Convert.ToChar(Console.ReadLine());
            } while (choice == 'y' | choice == 'Y');
        }
    }
}
