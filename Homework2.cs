using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorUnitTests
{
    internal class Homework2
    {
        [Test]
        static void Main(string[] args)
        {

            DateTime currentDate = DateTime.Now;

            DayOfWeek currentWeekday = currentDate.DayOfWeek;

            Assert.AreEqual(DayOfWeek.Wednesday, currentWeekday);
        }
    }



    
}


