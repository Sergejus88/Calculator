using Calculator2;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class CalculatorUnitsTests
    {
        [Test]
        public void Sum1And1()
        {
            int expectedResult = 2;

            int actualResult = Calculator2.Calculator.Sum(1, 1);

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Sum2And2()
        {
            Assert.AreEqual(4, Calculator2.Calculator.Sum(2, 2));
        }

        [Test]
        public void SumDecimal01And01And01()
        {
            decimal expectedResult = 0.3m;

            decimal actualResult = Calculator2.Calculator.SumDecimal3(0.1m, 0.1m, 0.1m);

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Sum3And3()
        {
            Assert.AreEqual(6, Calculator2.Calculator.Sum(3, 3));
        }
    }

}   