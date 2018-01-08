using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Student
{
    class Student
    {
        private double marks1;
        private double marks2;
        private double marks3;
        private double perc;

        public double Marks1
        {
            get
            {
                return marks1;
            }
            set
            {
                if (value > 100)
                {
                    marks1 = value % 100;
                }
                else
                {
                    marks1 = value;
                }
            }
        }
        public double Marks2
        {
            get
            {
                return marks2;
            }
            set
            {
                if (value > 100)
                {
                    marks2 = value % 100;
                }
                else
                {
                    marks2 = value;
                }
            }
        }
        public double Marks3
        {
            get
            {
                return marks3;
            }
            set
            {
                if (value > 100)
                {
                    marks3 = value % 100;
                }
                else
                {
                    marks3 = value;
                }
            }
        }
        public double Perc
        {
            get
            {
                return perc;
            }
            set
            {
                perc = value;
            }
        }

        public void Execute()
        {
            Console.Write("Enter marks for 1st Subject (Max: 100): ");
            Marks1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter marks for 2nd Subject (Max: 100): ");
            Marks2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter marks for 3rd Subject (Max: 100): ");
            Marks3 = Convert.ToDouble(Console.ReadLine());

            Perc = Math.Round((Marks1 + Marks2 + Marks3) / 3, 2);

            Console.WriteLine("Percentage of the Student is: {0}", Perc);
        }
    }
}