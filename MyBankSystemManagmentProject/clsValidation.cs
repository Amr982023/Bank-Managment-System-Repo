using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyBankSystemManagmentProject
{
    internal class clsValidation
    {
        public static bool ValidateEmail(string emailAddress)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(emailAddress);
                return addr.Address == emailAddress;
            }
            catch
            {
                return false;
            }
        }

        public static bool ValidateInteger(string number)
        {
            var pattern = @"^[0-9]+(\.[0-9]+)?$";
            return Regex.IsMatch(number, pattern);
        }
        public static bool ValidateLetter(string number)
        {
            var pattern = @"^[A-Za-z]+$";
            return Regex.IsMatch(number, pattern);
        }
        
        public static bool ValidateFloat(string number)
        {
            var pattern = @"^[0-9]+(\.[0-9]+)?$";
            return Regex.IsMatch(number, pattern);
        }

        public static bool IsNumber(string number)
        {
            return ValidateInteger(number) || ValidateFloat(number);
        }

    }
}
