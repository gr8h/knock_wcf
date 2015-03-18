using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using knockknock.Domain;
using knockknock.Model;
using knockknock.Service.Implementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace knockknock.Service.Implementation.Tests
{
    [TestClass()]
    public class RedPillTests
    {
        IRedPill p = new RedPill();

        [TestMethod()]
        public void FibonacciNumberTest()
        {
            long expected = 12586269025;
            long actual;

            actual = p.FibonacciNumber(50);
            Assert.AreEqual<long>(expected, actual);
        }

        [TestMethod()]
        public void ReverseWordsTest()
        {
            string expected = "dlrow olleh";
            string actual;

            actual = p.ReverseWords("hello world");

            Assert.AreEqual<string>(expected, actual);
        }

        [TestMethod()]
        public void WhatShapeIsThisTest()
        {
            TriangleType expected = TriangleType.Equilateral;
            TriangleType actual;

            actual = p.WhatShapeIsThis(8, 8, 8);

            Assert.AreEqual<TriangleType>(expected, actual);
        }
    }
}
