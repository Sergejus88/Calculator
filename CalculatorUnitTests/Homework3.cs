using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorUnitTests
{
    internal class Homework3
    {
        [Test]
        static void Main(string[] args)
        {
            DateTime currentDate = DateTime.Now;

            int currentHour = currentDate.Hour;

            Assert.AreEqual(13, currentHour);
        }
    }
}
    

