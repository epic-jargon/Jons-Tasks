using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace JonsTasks
{
    class T1_URLChecker
    {
        private static String[] regex =
            {
                "^(https?|ftp|file):\\/\\/[-a-zA-Z0-9+&@#\\/%?=~_|!:,.;]*[-a-zA-Z0-9+&@#\\/%=~_|]\\.(co.uk|com)"
            };
        static void Main(string[] args)
        {
            while (true)
            {
                String input = Console.ReadLine();

                input = input.ToLower();
                if (input == "exit")
                    Environment.Exit(0);
                else if (input == "help" || input == "")
                    Console.WriteLine("help, exit");
                else
                {
                    Console.WriteLine((checkIfRegexMatches(input)) ? "url is valid" : "url is not valid");
                }
            }
        }
        static bool checkIfRegexMatches(String input)
        {
            foreach (String s in regex)
            {
                Regex rgx = new Regex(s);
                Match match = rgx.Match(input);
                if (match.Success)
                    return true;
            }
            return false;
        }
    }
}
