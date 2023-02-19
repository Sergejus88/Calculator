using NUnit.Framework;
using SeleniumFrameWork.Pages.SeleniumEasy;
using SeleniumFrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumFrameWork.Pages.DemoQA;

namespace FinalWork
{
    public class FinalWorkTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.SetupDriver();
            FinalWork.Open();
        }

        [Test]
        public void FillSignUp()
        {
            Driver.SetupDriver();
            Driver.OpenUrl("https://www.1a.lt/users/sign_up");

            string expectedResult = FinalWork.FillSignUp();

            string inputFirstName = "Sergejus";
            string inputLastname = "Semionkinas";
            string inputEmail = "sergejus.semionkinas@gmail.com";
            string inputPassword = "Dtys7x@YDdB6XeV";
            string inputReapetPassword = "Dtys7x@YDdB6XeV"; 

            FinalWork.inputFirstName(inputFirstName);
            FinalWork.inputLastName(inputLastname);
            FinalWork.inputEmailSignUP(inputEmail);
            FinalWork.inputPassword(inputPassword);
            FinalWork.inputReapetPassword(inputReapetPassword);
            FinalWork.ClickSubmitButton();
            string actualResult = FinalWork.FillSignUp();

            Assert.AreEqual(expectedResult, actualResult);

            Driver.CloseDriver();
        }

        [Test]
        public void SignIn()
        {
            Driver.SetupDriver();
            Driver.OpenUrl("https://www.1a.lt/users/sign_in");

            string expectedResult = "sergejus.semionkinas@gmail.com";
            string InputPassword = "Dtys7x@YDdB6XeV";

            FinalWork.InputEmail(expectedResult);
            FinalWork.InputPassword(InputPassword);

            string actualResult = FinalWork.GetSignIn();

            Assert.AreEqual(expectedResult, actualResult);

            Driver.CloseDriver();
        }

        [Test]
        public void WaitForTheSearchingIsDone()
        {
            Driver.SetupDriver();
            Driver.OpenUrl("https://www.1a.lt/");

            Assert.IsTrue(FinalWork.WaitForTheSearchingIsDone());
        }

        [Test]
        public void AddNumbersToGetSmartNetCard()
        {
            Driver.SetupDriver();
            Driver.OpenUrl("https://www.1a.lt/physical_smart_card/new");

             string valueInputNumbers = "InvalidNumbers";

             FinalWork.EnterNumbers(valueInputNumbers);
             FinalWork.ClickSubmitButton();

             Assert.IsTrue(FinalWork.CheckIfErrorIsDisplayed());
             Assert.IsTrue(FinalWork.CheckIfAdndWhatWillBeDisplayed());
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }

    }
}
