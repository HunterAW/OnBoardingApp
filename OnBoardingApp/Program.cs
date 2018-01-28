using System;
using System.Globalization;

namespace OnBoardingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hunter's Bank of Awesome, where we strive to be the leader in the storing of Awesome.\nWould you like to create an account? | y/n");
            var signInResponse = Console.ReadLine();
            User user = new User();

            while (signInResponse != "y" && signInResponse != "n")
            {
                Console.WriteLine("Nope! I said y or n. how hard is that?\nTry Again...");
                signInResponse = Console.ReadLine();
            }

            if (signInResponse == "n")
            {
                Console.WriteLine("Thanks for stopping by! I bet you don't even have any Awesome to store anyway.\nGood riddance to Awesomeless rubish.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            if (signInResponse == "y")
            {
                Console.WriteLine();
                {
                    Console.WriteLine("Fantastic! Let's get started!\nPlease enter your first name.");
                    user.FirstName = Console.ReadLine();

                    Console.WriteLine("That is a great name!\nPlease enter your last name.");
                    user.LastName = Console.ReadLine();

                    Console.WriteLine($"Welcome to Hunter's Bank of Awesome {user.FirstName} {user.LastName}!");
                }
            }

            Console.WriteLine("Time to assign a pin to your account so that no one will try and swipe your Awesome.\nPlease enter a 4 character pin.");
            user.Pin = Console.ReadLine();

            while (user.Pin.Length != 4)
            {
                Console.WriteLine($"4 characters not {user.Pin.Length}...\nTry again...");
                user.Pin = Console.ReadLine();
            }

            Console.WriteLine("Thank you for setting up an Account with Hunter's Bank of Awesome!\nHow much awesome would you like to deposite today?");

            user.Awesome = 0;
            while (user.Awesome == 0)
                try
                {
                    user.Awesome = float.Parse(Console.ReadLine());
                }

                catch
                {
                    Console.WriteLine("Please state the numerical value of how much Awesome you would like to deposite.");
                    user.Awesome = float.Parse(Console.ReadLine());
                }

            if (user.Awesome < 10)
            {
                Console.WriteLine($"Well... {user.Awesome} isn't zero Awesome, that's something at least. Thanks for using Hunter's Bank of Awesome.");
            }

            if (user.Awesome >= 10 && user.Awesome < 100)
            {
                Console.WriteLine($"Thank you for depositing {user.Awesome} Awesome Please come again.");
            }

            if (user.Awesome >= 100)
            {
                Console.WriteLine($"Wow {user.Awesome} Awesome! Please come again and grace us with your presence in the future!");
            }

            Console.ReadLine();
        }
    }
}
