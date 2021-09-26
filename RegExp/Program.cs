using System;

namespace RegExp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User registration");
            Pattern pattern = new Pattern();
            // pattern.IsValidFirstName();
            //pattern.IsValidLastName();
            //pattern.IsValidEmail();
            // pattern.IsValidPhoneNo();
            //pattern.IsValidPasswordRule4();
            pattern.IsValidSampleEmail("abc@yahoo.com");
            pattern.IsValidSampleEmail("abc-100@yahoo.com");
            pattern.IsValidSampleEmail("abc@gmail.com.com");
            pattern.IsValidSampleEmail("abc.100@yahoo.com");
            pattern.IsValidSampleEmail("abc111@abc.com");
        }
    }
}
