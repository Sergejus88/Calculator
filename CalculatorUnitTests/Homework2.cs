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
            
            DateTime today = DateTime.Now;
            Console.WriteLine("Today is: " + DateTime.Today.DayOfWeek);
            Console.ReadLine();
        }
    
    }
}
