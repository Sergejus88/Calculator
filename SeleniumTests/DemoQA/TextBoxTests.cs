using NUnit.Framework;
using SeleniumFrameWork.Pages.SeleniumEasy;
using SeleniumFrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumFrameWork.Pages.DemoQA;

namespace SeleniumTests.DemoQA
{
    public class TextBoxTests
    {
        [Test]
        public void TextBox()
        {
            Driver.SetupDriver();
            Driver.OpenUrl("https://demoqa.com/text-box");

            string expectedResult = "Sergejus";
            string inputE = "sergejus.semionkinas@gmail.com";
            string inputCurrent = "Kolokotroni20";
            string inputPermanent = "Misku36"; ;

            SimpleFormDemo.inputFullName(expectedResult);
            SimpleFormDemo.InputE(inputE);
            SimpleFormDemo.inputCurrent(inputCurrent);
            SimpleFormDemo.inputPermanent(inputPermanent);
            SimpleFormDemo.ClickGetTotalButton();
            string actualResult = SimpleFormDemo.GetTextBox();

            Assert.AreEqual(expectedResult, actualResult);

            Driver.CloseDriver();
        }

        [Test]
        public void FillBadFormaWithInvalidEmail()
        {
            Driver.SetupDriver();
            Driver.OpenUrl("https://demoqa.com/text-box");

            string valueInputEmail = "InvalidEmail";

            SimpleFormDemo.InputEInvalidEmail(valueInputEmail);
            SimpleFormDemo.ClickGetTotalButton();
            string actualResult = SimpleFormDemo.GetFillBadFormaWithInvalidEmail();

            Driver.CloseDriver();
        }



        // destytojo pavyzdys//
        [SetUp]
        public void SetUp()
        {
            Driver.SetupDriver();
            TextBoxDemo.Open();
        }
        [Test]
        public void FillFormWithValidEmail()
        {
            string valueInputName = "My Name";
            string valueInputEmail = "email@email.com";
            string valueInputCurrentAddress = "My current address";
            string valueInputPermanentAddress = "My permanent address";

            TextBoxDemo.EnterFullName(valueInputName);
            TextBoxDemo.EnterEmail(valueInputEmail);
            TextBoxDemo.EnterCurrentAddress(valueInputCurrentAddress);
            TextBoxDemo.EnterPermanentAddress(valueInputPermanentAddress);
            TextBoxDemo.ClickSubmitButton();

            string actualFullName = TextBoxDemo.GetFullNameOutput();
            string actualEmail = TextBoxDemo.GetEmailOutput();
            string actualCurrentAddress = TextBoxDemo.GetCurrentAddressOutput();
            string actualPermanentAddress = TextBoxDemo.GetPermanentAddressOutput();

            Assert.IsTrue(actualFullName.Contains(valueInputName));
            Assert.IsTrue(actualEmail.Contains(valueInputEmail));
            Assert.IsTrue(actualCurrentAddress.Contains(valueInputCurrentAddress));
            Assert.IsTrue(actualPermanentAddress.Contains(valueInputPermanentAddress));
        }


        [Test]
        public void FillBadFormaWithInvalidEmail0()
        {
            string valueInputEmail = "InvalidEmail";

            TextBoxDemo.EnterEmail(valueInputEmail);
            TextBoxDemo.ClickSubmitButton();

            Assert.IsTrue(TextBoxDemo.CheckIfEmailErrorIsDisplayed());
            Assert.IsTrue(TextBoxDemo.CheckIfEmailBorderIsRed());
        }

        [TearDown]

        public void Teardown()
        {
            Driver.CloseDriver();
        }
    }
}                   


































    
