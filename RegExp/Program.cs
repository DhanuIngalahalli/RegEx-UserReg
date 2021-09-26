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
            pattern.IsValidEmail();
        }
    }
}
