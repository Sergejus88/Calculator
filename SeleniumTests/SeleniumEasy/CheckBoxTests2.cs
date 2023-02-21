using NUnit.Framework;
using SeleniumFrameWork.Pages.SeleniumEasy;
using SeleniumFrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Internal;

namespace SeleniumTests.SeleniumEasy
{
    internal class CheckBoxTests2
    {

        [SetUp]
        public void SetUp()
        {
            Driver.SetupDriver();
            Driver.OpenUrl("https://demo.seleniumeasy.com/basic-checkbox-demo.html");
        }

        [Test]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demo.seleniumeasy.com/basic-checkbox-demo.html");

            string expectedResult = "Unheck All";
            string actualResult = "Uncheck All";

            var actualSingleButton = driver.FindElement(By.Id("//*[@id='isAgeSelected']"));
            var actualButton1 = driver.FindElement(By.Id("//*[@id='easycont']"));
            var actualButton2 = driver.FindElement(By.Id("//*[@id='easycont']"));
            var actualButton3 = driver.FindElement(By.Id("//*[@id='easycont']"));
            var actualButton4 = driver.FindElement(By.Id("//*[@id='easycont']"));

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Test2()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demo.seleniumeasy.com/basic-checkbox-demo.html");

            List<IWebElement> elements = (List<IWebElement>)driver.FindElement(By.Id("//*[@id='easycont']"));

            foreach (IWebElement element in elements)
            {
                element.Click();
            }

            List<IWebElement> elements1 = (List<IWebElement>)driver.FindElement(By.Id("//*[@id='easycont']"));

            foreach (IWebElement element in elements)
            {
                element.Click();
            }

            List<IWebElement> elements2 = (List<IWebElement>)driver.FindElement(By.Id("//*[@id='easycont']"));

            foreach (IWebElement element in elements)
            {
                element.Click();
            }

            List<IWebElement> element3 = (List<IWebElement>)driver.FindElement(By.Id("//*[@id='easycont']"));

            foreach (IWebElement element in elements)
            {
                element.Click();
            }

            Assert.AreEqual(1, elements1.Count);
        }

        [Test]
        public void Test3()
        {
            string expectedButtonText = "Uncheck All";
            string expectedValue = "Does not change";

            CheckBoxDemo2.ClickEachOfMultipleCheckboxes();
            string actualButtonText = CheckBoxDemo2.GetMultipleCheckboxButtonText();
            string actualValue = "Changes - Check All";

            Assert.AreEqual(expectedButtonText, actualButtonText, expectedValue, actualValue);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
