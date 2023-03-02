using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTestWithoutPom
{
    public class SeleniumEASY
    {

        [Test]
        public void SingleInputField()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";

            string expectedResult = "Test";

            IWebElement inputEnterMessage = driver.FindElement(By.XPath("//*[@id='user-message']"));
            IWebElement buttonShowMessage = driver.FindElement(By.XPath("//*[@id='get-input']/button"));
            IWebElement spanMessageText = driver.FindElement(By.XPath("//*[@id='display']"));

            inputEnterMessage.SendKeys(expectedResult);
            buttonShowMessage.Click();
            string actualResult = spanMessageText.Text;

            Assert.AreEqual(expectedResult, actualResult);

            driver.Quit();

        }

        [Test]
        public void TwoInputFields()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";

            string inputAValue = "5";
            string inputBValue = "10";
            string expectedResult = "15";

            IWebElement inputA = driver.FindElement(By.XPath("//*[@id='sum1']"));
            IWebElement inputB = driver.FindElement(By.XPath("//*[@id='sum2']"));
            IWebElement buttonGetTotal = driver.FindElement(By.XPath("//*[@id='gettotal']/button"));
            IWebElement SpanTotalMessage = driver.FindElement(By.XPath("//*[@id='displayvalue']"));

            inputA.SendKeys(inputAValue);
            inputB.SendKeys(inputBValue);
            buttonGetTotal.Click();
            string actualResult = SpanTotalMessage.Text;

            Assert.AreEqual(expectedResult, actualResult);

            driver.Quit();
        }
    }
}

