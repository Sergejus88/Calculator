using NUnit.Framework;
using SeleniumFrameWork;
using SeleniumFrameWork.Pages.SeleniumEasy;

namespace SeleniumTests.SeleniumEasy
{
    internal class SeleniumFormDemoTests
    {
        [Test]
        public void SingleInputField()
        {
            Driver.SetupDriver();
            Driver.OpenUrl("https://demo.seleniumeasy.com/basic-first-form-demo.html");

            string expectedResult = "Test";

            SimpleFormDemo.EnterMessage(expectedResult);
            SimpleFormDemo.ClickShowMessageButton();
            string actualResult = SimpleFormDemo.GetSingleInputFieldMessage();

            Assert.AreEqual(expectedResult, actualResult);

            Driver.CloseDriver();

        }

        [Test]
        public void TwoInputFields()
        {
            Driver.SetupDriver();
            Driver.OpenUrl("https://demo.seleniumeasy.com/basic-first-form-demo.html");

            string inputAValue = "5";
            string inputBValue = "10";
            string expectedResult = "15";

            SimpleFormDemo.EnterInputA(inputAValue);
            SimpleFormDemo.EnterInputB(inputBValue);
            SimpleFormDemo.ClickGetTotalButton();
            string actualResult = SimpleFormDemo.GetTwoInputFieldsMessage();

            Assert.AreEqual(expectedResult, actualResult);

            Driver.CloseDriver();
        }

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
    }
}
