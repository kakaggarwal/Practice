using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Arrays
{
    class ArrayPractice
    {
        public static void Test()
        {
            // Testing the ways in which the arrays can be initialized.
            int[] array1 = new int[] { 1, 2, 2, 3, 3 };
            string[] array2 = new string[] { "Sun", "Mon", "Tue", "Wed", "Thurs", "Fri", "Sat" };
            int[] array3 = { 4, 5, 6, 7, 8, 9 };
            string[] array4 = { "vbjhdvbjhfd", "vghsdvjsf", "vhvbh", "vjkdbvbjdf" };

            //Console.WriteLine(array1);
            //Console.WriteLine(array2);
            //Console.WriteLine(array3);
            //Console.WriteLine(array4);

            

            int[,] array2D = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };

            int[][] jaggedArray = new int[][]
            {
                new int[] { 1, 2, 3, 4 },
                new int[] { 5, 6, 7 }
            };

            //foreach (var item in array2D)
            //{
            //    Console.WriteLine(item);
            //}

            Console.Write("Initial Array: ");
            array2.ToList().ForEach(s => Console.Write(s + " "));
            Console.WriteLine();

            ChangeArray(array2);

            Console.Write("Array after call to ChangeArray: ");
            array2.ToList().ForEach(s => Console.Write(s + " "));
            Console.WriteLine();

            ChangeArrayElements(array2);

            Console.Write("Array after call to ChangeArrayElements: ");
            array2.ToList().ForEach(s => Console.Write(s + " "));
            Console.WriteLine();
        }

        public static void ChangeArray(string[] weekDays)
        {
            weekDays = weekDays.Reverse().ToArray();

            Console.Write("Array in ChangeArray func: ");
            weekDays.ToList().ForEach(s => Console.Write(s + " "));
            Console.WriteLine();
        }

        public static void ChangeArrayElements(string[] weekDays)
        {
            weekDays[0] = "Jasmine";
            weekDays[1] = "Miranda";
            weekDays[2] = "Carolina";

            Console.Write("Array in ChangeArrayElements func: ");
            weekDays.ToList().ForEach(s => Console.Write(s + " "));
            Console.WriteLine();
        }
    }
}
