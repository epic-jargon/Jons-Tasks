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
        public const string Welcome = "welcome to the email checker";

        static void Main(string[] args)
        {
            Console.WriteLine(Welcome);
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
                    Console.WriteLine((checkIfEmailIsValid(input)) ? "email is valid" : "email is not valid");
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
                catch //(incorectFormatExcrption ex)
            {
                    return false;
                }
        }
    }
}
