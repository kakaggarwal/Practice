using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Employee
{
    class Helper
    {
        public static void CalSalary()
        {
            string empName;
            char experienced;
            int age;

            Console.WriteLine("Enter the Employee Details: ");
            Console.Write("Name: ");
            empName = Console.ReadLine();
            Console.Write("Experienced (y/n): ");
            experienced = Convert.ToChar(Console.ReadLine());
            Console.Write("Age (in yrs): ");
            age = Convert.ToInt32(Console.ReadLine());

            if (experienced == 'y' | experienced == 'Y')
            {
                if (age > 35)
                {
                    Console.WriteLine("Salary is Rs.6000/-");
                }
                else if (age > 28)
                {
                    Console.WriteLine("Salary is Rs.4800/-");
                }
                else
                {
                    Console.WriteLine("Salary is Rs.3000/-");
                }
            }
            else
            {
                Console.WriteLine("Salary is Rs.2000/-");
            }
        }
    }
}
