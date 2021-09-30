using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace RegExp
{
    public class Pattern
    {
        //regex patterns
        public static string Regex_name = "^[A-Z]{1}[a-z]{2,}$";
        public static string Regex_email = "^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
        public static string Regex_phone = "^[1-9]{1}[0-9]{1}\\s[1-9]{1}[0-9]{9}$";
        public static string Regex_password = "(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*()_+=-])[a-zA-Z0-9!@#$%^&*()_+=-]{8,}$";
        public bool ValidateFirstName(string firstName)//method to check firstname
        {
            if (firstName == null)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionsType.Invalid_MESSAGE, "Invalid FirstName");
            }
            return Regex.IsMatch(firstName, Regex_name);
        }
        public bool ValidateLastName(string lastName)//method to check lastname
        {
            if (lastName == null)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionsType.Invalid_MESSAGE, "Invalid LastName");
            }
            return Regex.IsMatch(lastName, Regex_name);
        }
        public bool ValidateEmailId(string emailId)//method to check mailId
        {
            if (emailId == null)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionsType.Invalid_MESSAGE, "Invalid Email ID");
            }
            return Regex.IsMatch(emailId, Regex_email);
        }
        public bool ValidateMobileNumber(string mobileNumber)//method to check mobileno
        {
            if (mobileNumber == null)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionsType.Invalid_MESSAGE, "Invalid Mobile Number");
            }
            return Regex.IsMatch(mobileNumber, Regex_phone);
        }
        public bool ValidatePassword(string password)//method to check password
        {
            if (password == null)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionsType.Invalid_MESSAGE, "Invalid Password");
            }
            return Regex.IsMatch(password, Regex_password);

        }

    }
}
