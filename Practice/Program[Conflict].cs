using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            char choice = 'n';

            try
            {
                do
                {
                    //DecToBin dectobin = new DecToBin();

                    //dectobin.DecimalToBinary();

                    //*****************************

                    //Console.WriteLine(CalExponent.Exponent(2, 4));

                    //*********************************

                    //BinToDec bintodec = new BinToDec();

                    //bintodec.BinaryToDecimal();

                    //*********************************

                    //CharASCIICode.CharASCIICodeOf();
                    //CharASCIICode.ASCIIToCharOf();

                    //********************************

                    //DayConverter.ConvertDays();

                    //********************************

                    //CharPrint.CharSeqPrint();

                    //********************************

                    //Largest.LargestOfAll();

                    //********************************

                    //TemperatureConvertor.ConvertTemp();

                    //********************************

                    //Console.WriteLine(Helper.StringReverse("strong"));

                    //********************************

                    //Student.Student student = new Student.Student();

                    //student.Execute();
                    //Student.Competition.FormTeams();

                    //********************************

                    //Employee.Helper.CalSalary();

                    //********************************

                    //Interest.Helper.CalInterest();

                    //********************************

                    //Console.WriteLine(Calc.SumOf(215614646, 314515616));
                    //Console.WriteLine(Calc.ProductOf(24, 14));
                    //Console.WriteLine(Calc.SquareOf(24));
                    //Console.WriteLine(Calc.CubeOf(5));
                    //Calc.Solve();
                    //Console.WriteLine(Calc.FactorialOf(5));
                    //Calc.PrimeCheck();

                    //********************************

                    //Helper.PalindromeCheck();

                    //********************************

                    //Calc.Factors();

                    //***************************

                    //Calc.Factors();

                    //***************************

                    //Calc.OddorEven();

                    //*****************

                    //Helper.LeapYearCheck();

                    //******************

                    //Calc.Fibonacci();

                    //********************

                    //Helper.DescendingArrange();
                    //Helper.AscendingArrange();
                    //Helper.RightAnglePattern();
                    //Helper.InvertedTrianglePattern();
                    //Helper.StringToUpper();
                    //Helper.CountString();

                    #region PoPrep
                    //***********************
                    // PO Preperation Programs
                    //POPrep.PoPrep.Choice();
                    #endregion

                    #region Interview
                    Console.WriteLine(Interview.Interview.HasDuplicates(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }));
                    #endregion

                    Console.Write("Do you want to continue (y/n)? ");
                    choice = Convert.ToChar(Console.ReadLine());
                } while (choice == 'y' | choice == 'Y');
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
