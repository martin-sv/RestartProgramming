using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        public static NumberFormatInfo nfi = new CultureInfo("en-US").NumberFormat;
        static void Main(string[] args)
        {
            nfi.NumberDecimalDigits = 0;

            Fibonachi fibo = new Fibonachi();
            fibo.RunFibonachi(20);
            //for (int i = 0; i <= 50; i++)
                //Console.WriteLine("Fibonachi {0}: {1}", i, fibo.RunFibonachi(i).ToString("N", nfi));
            Console.WriteLine("End");
        }
    }
}