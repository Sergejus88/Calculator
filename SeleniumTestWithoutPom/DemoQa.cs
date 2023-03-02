using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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

        // Destytojo pavyzdys//

        [Test]
        public void FillFormWithValidEmail()
        {
            string valueInputName = "My Name";
            string valueInputEmail = "email@email.com";
            string valueInputCurrentAddress = "My current address";
            string valueInputPermanentAddress = "My permanent address";

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/text-box";

            IWebElement inputName = driver.FindElement(By.XPath("//*[@id='userName']"));
            IWebElement inputEmail = driver.FindElement(By.XPath("//*[@id='userEmail']"));
            IWebElement inputCurrentAddress = driver.FindElement(By.XPath("//*[@id='currentAddress']"));
            IWebElement inputPermanentAddress = driver.FindElement(By.XPath("//*[@id='permanentAddress']"));

            IWebElement buttonSubmit = driver.FindElement(By.XPath("//*[@id='submit']/.."));

            inputName.SendKeys(valueInputName);
            inputEmail.SendKeys(valueInputEmail);
            inputCurrentAddress.SendKeys(valueInputCurrentAddress);
            inputPermanentAddress.SendKeys(valueInputPermanentAddress);

            // Būdas pascrollinti žemyn kai mygtuko elementą uždengia footer elementas
            // Senas būdas
            //IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            //jse.ExecuteScript("window.scrollBy(0, 200)");

            // Naujas būdas
            driver.ExcecuteJavaScript("window.scrollBy(0, 100)");
            buttonSubmit.Click();

            IWebElement outputName = driver.FindElement(By.XPath("//*[@id='output']//*[@id='name']"));
            IWebElement outputEmail = driver.FindElement(By.XPath("//*[@id='output']//*[@id='email']"));
            IWebElement outputCurrentAddress = driver.FindElement(By.XPath("//*[@id='output']//*[@id='currentAddress']"));
            IWebElement outputPermanentAddress = driver.FindElement(By.XPath("//*[@id='output']//*[@id='permanentAddress']"));

            Assert.IsTrue(outputName.Text.Contains(valueInputName));
            Assert.IsTrue(outputEmail.Text.Contains(valueInputEmail));
            Assert.IsTrue(outputCurrentAddress.Text.Contains(valueInputCurrentAddress));
            Assert.IsTrue(outputPermanentAddress.Text.Contains(valueInputPermanentAddress));

            driver.Quit();
        }

        [Test]
        public void FillFormWithInvalidEmail()
        {
            string valueInputEmail = "invalidEmail";

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/text-box";

            IWebElement inputEmail = driver.FindElement(By.XPath("//*[@id='userEmail']"));
            IWebElement buttonSubmit = driver.FindElement(By.XPath("//*[@id='submit']/.."));


            inputEmail.SendKeys(valueInputEmail);
            buttonSubmit.Click();

            // Patikriname, kad buvo uždėta papildoma klasė input elementui
            Assert.IsTrue(inputEmail.GetAttribute("class").Contains("field-error"));

            // Patikriname realią border spalvą
            // Reikia palaukti, nes kitaip testas spėja nuskaityti seną spalvą ir failina
            System.Threading.Thread.Sleep(500);
            Assert.AreEqual("rgb(255, 0, 0)", inputEmail.GetCssValue("border-color"));

            driver.Quit();
        }
    }
}      
