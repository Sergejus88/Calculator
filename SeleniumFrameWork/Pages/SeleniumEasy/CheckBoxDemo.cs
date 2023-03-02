using System;

namespace SeleniumFrameWork.Pages.SeleniumEasy
{
    public class CheckBoxDemo
    {
        private static string inputsMultipleCheckbox = "//*[@id=check1]";
        private static string buttonMultipleCheckboxes = "*[@class='cb1-element']";
        private static string inputSingleCheckbox = "//*[@id='isAgeSelected']";
        private static string fieldSingleCheckboxSuccessMessage = "//*[@id=txtAge]";

        public static void Open()
        {
            Driver.OpenUrl("https://demo.seleniumeasy.com/basic-checkbox-demo.html");
        }
        public static void ClickSingleCheckbox()
        {
            Common.ClickElement(inputSingleCheckbox);
        }
        public static string GetSingleCheckboxSuccessMessage()
        {
            return Common.GetElementText(fieldSingleCheckboxSuccessMessage);
        }

        public static void ClickEachOfMultipleCheckboxes()
        {
            Common.ClickElements(inputsMultipleCheckbox);
        }

        public static string GetMultipleCheckboxButtonText()
        {
            return Common.GetAttributeValue(buttonMultipleCheckboxes, "value");
        }
    }
}

