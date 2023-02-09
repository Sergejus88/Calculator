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
            DateTime now = DateTime.Now;
            Console.WriteLine("The current time is: " + now.ToString("13:00:00"));
            Console.ReadLine();
        }
    }
}
    

