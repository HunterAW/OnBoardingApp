using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OnBoardingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hunter's Bank of Awesome, where we strive to be the leader in the storing of Awesome.\nWould you like to create an account? | y/n");
            var signInResponse = Console.ReadLine();

            while (signInResponse != "y" && signInResponse != "n")
            {
                Console.WriteLine("Nope! I said y or n. how hard is that?\nTry Again...");
                signInResponse = Console.ReadLine();
            }

            if (signInResponse == "n")
            {
                Console.WriteLine("Thanks for stopping by! I bet you don't even have any Awesome to store anyway.\nGood ridence to Awesomeless rubish.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            if (signInResponse == "y")
            {
                Console.WriteLine();    
                {
                    User user = new User();
                    Console.WriteLine("Fantastic! Let's get started!\nPlease enter your first name.");
                    user.FirstName = Console.ReadLine();
                    
                    Console.WriteLine("That is a great name!\nPlease enter your last name.");
                    user.LastName = Console.ReadLine();

                    Console.WriteLine($"Welcome to Hunter's Bank of Awesome {user.FirstName} {user.LastName}!");
                }
            }

            Console.WriteLine("end test");



            Console.ReadLine();
        }
    }
}
