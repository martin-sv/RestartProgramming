using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestartProgrammingNF
{
    class Program
    {
        public static NumberFormatInfo nfi = new CultureInfo("en-US").NumberFormat;
        static void Main(string[] args)
        {
            nfi.NumberDecimalDigits = 0;

            Fibonachi fibo = new Fibonachi();
            int fiboNro = 20;
            ulong fiboResult = fibo.RunFibonachi(fiboNro);
            //for (int i = 0; i <= 50; i++)
            //Console.WriteLine("Fibonachi {0}: {1}", i, fibo.RunFibonachi(i).ToString("N", nfi));
            Console.WriteLine("Fibonachi {0}: {1}", fiboNro, fiboResult.ToString("N", nfi));
            Console.WriteLine("End");
            Console.ReadLine();
        }
    }
}
