using EntityFramework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SeleniumFrameWork.Pages.SeleniumEasy
{


    public class CheckBoxDemo2
    {
        private static string inputsMultipleCheckbox = "//*[@class='cb1-element']";
        private static string buttonMultipleCheckboxes = "//*[@id='check1']";
        private static string inputSingleCheckbox = "//*[@id='isAgeSelected']";
        private static string fieldSingleCheckboxSuccessMessage = "//*[@id='txtAge']";
        private static string checkbox1Locator = $"({inputsMultipleCheckbox})[1]";
        private static string checkbox2Locator = $"({inputsMultipleCheckbox})[2]";
        private static string checkbox3Locator = $"({inputsMultipleCheckbox})[3]";
        private static string checkbox4Locator = $"({inputsMultipleCheckbox})[4]";

        public static void Open()
        {
            Driver.OpenUrl("https://demo.seleniumeasy.com/basic-checkbox-demo.html");
        }
        public static string GetMultipleCheckboxButtonText()
        {
            return Common.GetAttributeValue(buttonMultipleCheckboxes, "value");
        }

        public static void ClickCheckbox1()
        {
            Common.ClickElement(checkbox1Locator);
        }

        public static void ClickCheckbox2()
        {
            Common.ClickElement(checkbox2Locator);
        }

        public static void ClickCheckbox3()
        {
            Common.ClickElement(checkbox3Locator);
        }

        public static void ClickCheckbox4()
        {
            Common.ClickElement(checkbox4Locator);
        }

        public static void ClickButtonCheckAll()
        {
            Common.ClickElement(buttonMultipleCheckboxes);
        }

        public static bool GetCheckbox1Status()
        {
            return Common.IsElementSelected(checkbox1Locator);
        }

        public static bool GetCheckbox2Status()
        {
            return Common.IsElementSelected(checkbox2Locator);
        }

        public static bool GetCheckbox3Status()
        {
            return Common.IsElementSelected(checkbox3Locator);
        }

        public static bool GetCheckbox4Status()
        {
            return Common.IsElementSelected(checkbox4Locator);
        }

        public static List<bool> GetStatusOfAllCheckboxes()
        {
            return Common.GetMultipleElementSelectedStatus(inputsMultipleCheckbox);
        }
    }
}


