using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Security.Claims;
using DocumentFormat.OpenXml.Presentation;
using OpenQA.Selenium.DevTools.V108.Database;

namespace HomeWork2
{
    public class DemoQA
    {
        internal class Program
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
            public void TextBox2()
            {
                IWebDriver driver = new ChromeDriver();
                driver.Url = "https://demoqa.com/text-box";

                string expectedResult = "Sergejus";
                string inputE = "sgsdgddgdgh";
                string inputCurrent = "Kolokotroni20";
                string inputPermanent = "Misku36";
                string actualError = "class=field-error";



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

                Assert.AreEqual(expectedResult, actualResult, actualError);
             
                driver.Quit();
            }

        }
             
    }
}   
