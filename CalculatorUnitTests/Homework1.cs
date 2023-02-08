using NUnit.Framework;

namespace CalculatorUnitTests
{
    internal class Homework1
    {
        [Test]

        public void CheckReminder995DividedBy()
        {
            int expectedResult = 0;

            int actualResult = 995 % 3;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
