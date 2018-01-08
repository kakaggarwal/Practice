using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Interest
{
    class Helper
    {
        public static void CalInterest()
        {
            double principal;
            int time;

            Console.Write("Ente the Principal amount: ");
            principal = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the time period: ");
            time = Convert.ToInt32(Console.ReadLine());

            if (time > 10)
            {
                Console.WriteLine("The Simple Interest will be {0}", (principal * time * 0.08));
            }
            else
            {
                Console.WriteLine("The Simple Interest will be {0}", (principal * time * 0.12));
            }
        }
    }
}