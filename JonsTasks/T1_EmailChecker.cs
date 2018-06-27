using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace JonsTasks
{
    class T1_EmailChecker
    {
        public const string WelcomeMessage = "Welcome to the E-mail checker";
        public const string ValidMessage = "E-mail is valid";
        public const string InValidMessage = "E-mail is not valid";
        public const string InValidMessage = "There was an error :";

        static void Main(string[] args)
        {
            Console.WriteLine(WelcomeMessage);
            Console.WriteLine("============================");
            while (true)
            {
                Console.Write("Enter Email Address: ");
                String input = Console.ReadLine();

                input = input.ToLower();
                if (input == "exit")
                    Environment.Exit(0);
                else if (input == "help" || input == "")
                    Console.WriteLine("help, exit");
                else
                {
                    Console.WriteLine((checkIfEmailIsValid(input)) ? ValidMessage : InValidMessage);
                }
            }
        }
        static bool checkIfEmailIsValid(String input)
        {
                try
                {
                    var address = new System.Net.Mail.MailAddress(input);
                    return true;
                }
                catch (FormatException exception)
                {
                Console.WriteLine(ErrorMessage + " " + exception);
                return false;
                }
        }
    }
}
