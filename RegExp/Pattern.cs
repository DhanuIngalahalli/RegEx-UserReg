using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace RegExp
{
    class Pattern
    {
        public static string Regex_name = "^[A-Z]{1}[a-z]{2,}$";
        public static string Regex_email = "^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
        public void IsValidFirstName()
        {
            bool flag;
            Console.WriteLine("Enter the first name");

            do
            {
                string firstname = Console.ReadLine();
                flag = (Regex.IsMatch(firstname, Regex_name));
                if (flag == true)
                    Console.WriteLine("valid");
                else
                    Console.WriteLine("Invalid, Type again");
            }
            while (flag == false);

        }
        public void IsValidLastName()
        {
            bool flag;
            Console.WriteLine("Enter the last name");

            do
            {
                string lastname = Console.ReadLine();
                flag = (Regex.IsMatch(lastname, Regex_name));
                if (flag == true)
                    Console.WriteLine("valid");
                else
                    Console.WriteLine("Invalid, Type again");
            }
            while (flag == false);

        }
        public void IsValidEmail()
        {
            bool flag;
            Console.WriteLine("Enter the Email");
            do
            {
                string Email = Console.ReadLine();
                flag = (Regex.IsMatch(Email, Regex_email));
                if (flag == true)
                    Console.WriteLine("valid");
                else
                    Console.WriteLine("Invalid, Type again");

            }
            while (!flag);

        }
    }
}
