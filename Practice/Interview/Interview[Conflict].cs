using System;
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
        public static int MyProperty { get; set; }
        private int MyProperty2 { get; set; }
        protected int MyProperty3 { get; set; }
        internal int MyProperty4 { get; set; }
        protected internal int MyProperty5 { get; set; }

        public static bool HasDuplicates(int[] items)
        {
            try
            {
                for (int i = 0; i < items.Length; i++)
                {
                    for (int j = i + 1; j < items.Length; j++)
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
    }

    class Interview2 : Interview
    {
        public void Test()
        {
            // MyProperty2 could not be accessed hence verifying that members with private access modifiers cannot be access by inheriting class
            Console.WriteLine(MyProperty);
            Console.WriteLine(MyProperty3);
            Console.WriteLine(MyProperty4);
            Console.WriteLine(MyProperty5);
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
            Console.WriteLine(Interview.Interview.MyProperty);
        }
    }
}
