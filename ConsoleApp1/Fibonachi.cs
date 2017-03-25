using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    class Fibonachi
    {
        private ulong count = 0;
        private ulong fibonum = 0;
        public ulong Fibonum { get { return fibonum;  } }
        public Fibonachi()
        {

        }

        public Fibonachi(ulong fibo)
        {
            RunFibonachi(fibo);
        }
        public ulong RunFibonachi(ulong fibo)
        {
            //if (++count % 100000000 == 0)
                //Debug.WriteLine(count.ToString("N", Program.nfi));
            if (fibo == 1)
                return 1;
            else if (fibo == 0)
                return 0;
            else
                return (RunFibonachi(fibo - 1) + RunFibonachi(fibo - 2));
        }

        public void RunThreadedFibonachi(object ofibo)
        {
            ulong fibo = (ulong)ofibo;
            //if (++count % 100000000 == 0)
                //Debug.WriteLine(count.ToString("N", Program.nfi));
            if (fibo == 1)
            { 
                fibonum++;
                Console.WriteLine(fibonum);
            }
            else if (fibo > 1)
            {
                new Thread(RunThreadedFibonachi).Start(fibo - 1);
                new Thread(RunThreadedFibonachi).Start(fibo - 2);
            }
        }
    }
}
