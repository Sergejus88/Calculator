using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestWithoutPom
{
    internal class DemoQa
    {
        [Test]
        public void TextBox()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/text-box";

            string expectedResult = "Sergejus";
            string inputE = "sergejus.semionkinas@gmail.com";
            string inputCurrent = "Kolokotroni20";
            string inputPermanent = "Misku36"; ;


            IWebElement inputFullName = driver.FindElement(By.XPath("//*[@id='userName']"));
            IWebElement inputEmail = driver.FindElement(By.XPath("//*[@id='userEmail']"));
            IWebElement inputCurrentAdd = driver.FindElement(By.XPath("//*[@id='currentAddress']"));
            IWebElement inputPermanentAdd = driver.FindElement(By.XPath("//*[@id='permanentAddress']"));
            IWebElement buttonShowMessage = driver.FindElement(By.XPath("//*[@id='submit']"));
            IWebElement spanMessageText = driver.FindElement(By.XPath("//*[@id='output']"));


            inputFullName.SendKeys(expectedResult);
            inputEmail.SendKeys(inputE);
            inputCurrentAdd.SendKeys(inputCurrent);
            inputPermanentAdd.SendKeys(inputPermanent);

            buttonShowMessage.Click();
            string actualResult = spanMessageText.Text;

            Assert.AreEqual(expectedResult, actualResult);

            driver.Quit();

        }

        [Test]
        public void FillBadFormaWithInvalidEmail()
        {
            string valueInputEmail = "InvalidEmail";

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/text-box";

            IWebElement inputEmail = driver.FindElement(By.XPath("//*[@id='userEmail']"));
            IWebElement buttonSubmit = driver.FindElement(By.XPath("//*[@id='submit']"));

            inputEmail.SendKeys(valueInputEmail);
            buttonSubmit.Click();

            Assert.IsTrue(inputEmail.GetAttribute("class").Contains("field-error"));

            driver.Quit();
        } 
    }
}      
