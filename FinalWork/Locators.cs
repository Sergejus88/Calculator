using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalWork
{
    internal class Locators
    {
        internal class FinalWork
        {
            internal static string inputFirstName = "//*[@id=user_first_name]";
            internal static string inputLastName = "//*[@id=user_last_name]";
            internal static string inputEmail = "//*[@id=user_email]";
            internal static string inputPassword = "//*[@id=user_password]";
            internal static string inputReapetPassword = "//*[@id=user_password_confirmation]";
            internal static string buttonSubmit = "//*[@id=new_user]/div[9]/input";
            internal static object FillSignUp = "//*[@id=new_user]/div[9]/input";
            internal static object FillTheField = "//*[@id=physical_smart_card_card_number_suffix]";
            internal static string inputNumbers = "//*[@id=physical_smart_card_card_number_suffix]";
        }
    }
}
