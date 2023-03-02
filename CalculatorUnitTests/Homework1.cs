using NUnit.Framework;
using System;

namespace CalculatorUnitTests
{
    internal class Homework1
    {

        [Test]
        public void CheckReminder995DividedBy()
        {
            int expectedResult = 2;

            int actualResult = 995 % 3;

            Assert.AreEqual(expectedResult, actualResult);
            
        }

        [Test]
        public void CheckIfTodayIsWednesday()
        {
            DayOfWeek expectedResult = DayOfWeek.Wednesday;

            DayOfWeek actualResult = DateTime.Now.DayOfWeek;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void CheckIfTimeNowIs13h()
        {
            int expectedResult = 13;

            int actualResult = DateTime.Now.Hour;

            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// Pavyzdys kaip palyginti laiką įtraukiant ir minutes
        /// Naudojantis šiuo pavyzdžiu galima "pasigaminti" bet kokį datos ir laiko formatą
        /// </summary>
        [Test]
        public void CheckIfTimeNowIs1300h()
        {
            string expectedResult = "13:00";

            string actualResult = $"{DateTime.Now.Hour}:{DateTime.Now.Minute}";
            string actualResultFormatted = DateTime.Now.ToString("HH:mm");

            Assert.AreEqual(expectedResult, actualResultFormatted);
        }

        [Test]
        public void CheckIfThereAre4EvenNumbersBetween1And10()
        {
            int evenNumbersCount = 0;

            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    evenNumbersCount++;
                }
            }
            Assert.AreEqual(4, evenNumbersCount);
        }
    }
}
