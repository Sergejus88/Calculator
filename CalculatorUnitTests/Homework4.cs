using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorUnitTests
{
    internal class Homework4
    {
        [Test]
        static void Main(string[] args)
        {
            int count = 0;

            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Number of even  between 1 and 10 " + count );
            Console.ReadLine();
        }
    }
}
