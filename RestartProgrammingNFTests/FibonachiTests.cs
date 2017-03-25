using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestartProgrammingNF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestartProgrammingNF.Tests
{
    [TestClass()]
    public class FibonachiTests
    {
        ulong[] fibos = new ulong[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
        ulong[] fibosRes = new ulong[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377 };
        Fibonachi fibonachi = new Fibonachi();

        [TestMethod()]
        public void RunFibonachiTest()
        {


            foreach (int fibo in fibos)
                Assert.AreEqual(fibosRes[fibo], fibonachi.RunFibonachi(fibo));
        }
    }
}