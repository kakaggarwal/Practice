using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class DayConverter
    {
        public static void ConvertDays()
        {
            int totDays = 0;
            int years = 0;
            int weeks = 0;
            int days = 0;

            char choice = 'n';

            do
            {
                Console.Write("Enter the days to convert: ");
                totDays = Convert.ToInt32(Console.ReadLine());

                years = totDays / 365;
                totDays = totDays % 365;
                weeks = totDays / 7;
                totDays = totDays % 7;
                days = totDays;

                Console.WriteLine("Years: {0}\nWeeks: {1}\nDays: {2}");

                Console.Write("Do you want to continue (y/n)? ");
                choice = Convert.ToChar(Console.ReadLine());
            } while (choice == 'y' | choice == 'Y');
        }
    }
}
