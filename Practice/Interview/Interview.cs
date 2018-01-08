using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// verifying whether an accesss modifier or any access modifer is allowed on a namespace
// Inference: on declaring an access modifer with a namespace an error prompt is given stating that a namespace is not allowed to have an access modifier or an attribute.
namespace Practice.Interview
{
    // Verifying whether a top-level type, which has not been nested in some another type, is allowed only internal or public access modifier.
    // Inference: on declaring private access modifier an error is prompted that private, protected and protected internal access modifiers are not allowed directly in
    // a namespace.
    class Interview
    {
        const int MyProperty = 0;
        private int MyProperty2 { get; set; }
        protected int MyProperty3 { get; set; }
        internal int MyProperty4 { get; set; }
        protected internal int MyProperty5 { get; set; }

        public readonly int ReadonlyProperty = 1;

        public static bool HasDuplicates(int[] items)
        {
            try
            {
                int len = items.Length;

                for (int i = 0; i < len; i++)
                {
                    for (int j = i + 1; j < len; j++)
                    {
                        if (items[i] == items[j])
                        {
                            return true;
                        }
                    }
                }
            }
            catch (Exception) { }

            return false;
        }

        public static void Test()
        {
            // MyProperty2 could not be accessed hence verifying that members with private access modifiers cannot be access by inheriting class
            //Console.WriteLine(MyProperty);
            //Console.WriteLine(MyProperty3);
            //Console.WriteLine(MyProperty4);
            //Console.WriteLine("version 1");

            Console.WriteLine("Hi, I have 2 years of experience in developing Asp.Net MVC web applications and web service applications using Entity Framework, LINQ, Razor view, bootstrap, AngularJS, jquery, JavaScript, Bundling etc.".Length);
        }

        //public virtual Test3()
        //{
        //    // MyProperty2 could not be accessed hence verifying that members with private access modifiers cannot be access by inheriting class
        //    //Console.WriteLine(MyProperty);
        //    //Console.WriteLine(MyProperty3);
        //    //Console.WriteLine(MyProperty4);
        //    Console.WriteLine("version 1");

        //}
    }

    class Interview2 : Interview
    {
        //public override int MyProperty { get => base.MyProperty; set => base.MyProperty = value; }

        //public override void Test()
        //{
        //    // MyProperty2 could not be accessed hence verifying that members with private access modifiers cannot be access by inheriting class
        //    //Console.WriteLine(MyProperty);
        //    //Console.WriteLine(MyProperty3);
        //    //Console.WriteLine(MyProperty4);
        //    Console.WriteLine("version 2");
        //}

        public void Test2()
        {
            // MyProperty2 could not be accessed hence verifying that members with private access modifiers cannot be access by inheriting class
            //Console.WriteLine(MyProperty);
            //Console.WriteLine(MyProperty3);
            //Console.WriteLine(MyProperty4);
            Console.WriteLine("version 3");
        }

        public void Test4()
        {
            Console.WriteLine(ReadonlyProperty);
            //ReadonlyProperty = 4;

        }
    }

    class Interview3
    {
        Interview interview = new Interview();

        public void Test()
        {
            // Only properties with public, internal and protected internal are accessible
            // Hence, public: full access
            // internal: accessible within the containig namespace
            // protected internal: accessible within the containing namespace and within the containg class and inheriting classes.
            // Console.WriteLine(interview.MyProperty);
            Console.WriteLine(interview.MyProperty4);
            Console.WriteLine(interview.MyProperty5);
        }
    }

    //Therefore, a Struct cannot be static but the fields or methods within it can be static
    struct Interview5
    {
        public static int MyProperty { get; set; }
    } 
}

namespace Practice.Interview2
{
    public class Interview4
    {
        Interview.Interview interview = new Interview.Interview();

        private class Subclass
        {

        }

        public void Test()
        {
            //Hence a static member can only be accessed through the type and not through any instance created for a type.
            Console.WriteLine(interview.MyProperty4);
            //Console.WriteLine(Interview.Interview.MyProperty);
        }
    }
}

namespace Practice
{
    public class Interview5
    {
        public static int Test()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            ArrayList arrayList = new ArrayList();

            try
            {
                return 0;
            }
            finally
            {
                Console.WriteLine("No one can stop the finally block");
            }
        }

        public static void Test2()
        {
            int[] originalArray = { 1, 2, 3, 4, 5 };
            int[] cloneArray = (int[])originalArray.Clone();
            int[] copyArray = new int[5];
            originalArray.CopyTo(copyArray, 0);

            PrintArray(originalArray);
            PrintArray(cloneArray);
            PrintArray(copyArray);

            //originalArray[2] = 0;
            //cloneArray[2] = 1;
            copyArray[2] = 2;

            PrintArray(originalArray);
            PrintArray(cloneArray);
            PrintArray(copyArray);

            PrintArray(originalArray.Reverse().ToArray());
            PrintArray(originalArray.OrderByDescending(o => o).ToArray());
        }

        static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }
    }
}
