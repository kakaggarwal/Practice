using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class CharPrint
    {
        public static void CharSeqPrint()
        {
            char choice = 'n';
            char character;

            do
            {
                Console.Write("Enter any Character (a to j): ");
                character = Convert.ToChar(Console.ReadLine());

                if (character < 'a' | character > 'j')
                {
                    Console.WriteLine("Please enter a character between a to j.");
                    goto jump;
                }
                
                Console.Write("Next 4 characters are: ");

                for (int i = 1; i < 5; i++)
                {
                    Console.Write("{0}, ",Convert.ToChar(Convert.ToInt32(character) + i));
                }

                Console.WriteLine();

                jump:
                Console.Write("Do you want to continue (y/n)? ");
                choice = Convert.ToChar(Console.ReadLine());
            } while (choice == 'y' | choice == 'Y');
        }
    }
}
