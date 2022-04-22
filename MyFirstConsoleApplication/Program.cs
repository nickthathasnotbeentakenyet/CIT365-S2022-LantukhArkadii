using System;

namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Main()
        {
            // Call the method to create an instance of a person
            GetUserNameAndLocation();
            // Call the X-mass countdown method
            ChristmasCountdown();
            // Call the Glazer class with its method
            GlazerApp.RunExample();
            // exit the program
            Console.WriteLine("Press any key to exit...");
            _ = Console.ReadLine();
        }

        private static void GetUserNameAndLocation()
        {
            Console.WriteLine("What is your name? ");
            var personName = Console.ReadLine();
            Console.WriteLine($"Hi {personName}! Where are you from? ");
            var personLocation = Console.ReadLine();
            Console.WriteLine($"I have never been to {personLocation}. I bet it is nice. Press any key to continue...");
            // exit
            Console.ReadLine();

            var person = new Person
            {
                Name = personName,
                Location = personLocation
            };
        }
        private static void ChristmasCountdown()
        {
            // method calculates the number of days before X-mas this year.
            var currentDate = DateTime.Now.Date;
            Console.WriteLine($"Today's date is: {currentDate.ToString("dd/MM/yyyy")}");
            // this year date value is static due to the instructions
            var xmas = DateTime.Parse("2022, 12, 25");
            var daysUntilX = (xmas - currentDate).Days;
            Console.WriteLine($"There are {daysUntilX} days until Christmas");
            // exiting
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
        }

    }
}
