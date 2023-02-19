using System;

namespace SeleniumFrameWork.Pages.SeleniumEasy
{
    public class CheckBoxDemo
    {
        private static string inputSingleCheckBox = "//*[@id=isAgeSelected]";
        private static string fieldSingleCheckBoxSuccessesMessage = "//*[@id=txtAge]";
        private static string buttonMultipleCheckboxes = "*[@class='cb1-element']";
        private static string inputsMultipleCheckbox = "//*[@id=check1]";

        public static void Open()
        {
            Driver.OpenUrl("https://demo.seleniumeasy.com/basic-checkbox-demo.html");
        }

        public static void ClickSingleCheckbox()
        {
            Common.ClickElement(inputSingleCheckBox);
        }

        public static string GetSingleCheckboxDemoSuccessMessage()
        {
           return Common.GetElementText(fieldSingleCheckBoxSuccessesMessage);
        }

        public static void ClickEachofMultipleTextboxes()
        {
            Common.ClickElements(inputsMultipleCheckbox);
        }

        public static string GetMultipleCheckboxButtonText()
        {
            return Common.GetAttributeValue(buttonMultipleCheckboxes, "value");
        }
    }
}
