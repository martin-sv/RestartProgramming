// <copyright file="FibonachiTest.cs">Copyright ©  2017</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestartProgrammingNF;

namespace RestartProgrammingNF.Tests
{
    /// <summary>This class contains parameterized unit tests for Fibonachi</summary>
    [PexClass(typeof(Fibonachi))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class FibonachiTest
    {
        /// <summary>Test stub for RunFibonachi(Int32)</summary>
        [PexMethod]
        public ulong RunFibonachiTest([PexAssumeUnderTest]Fibonachi target, int fibo)
        {
            ulong result = target.RunFibonachi(fibo);
            return result;
            // TODO: add assertions to method FibonachiTest.RunFibonachiTest(Fibonachi, Int32)
        }
    }
}
