using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace regex
{
    internal class Validation
    {
        // this expression for first and last name UC1-2
        const string expression = "^[A-Z][a-zA-Z]{3,}$";

        //this expression for email-id UC3
        const string expression2 = "^[a-zA-Z0-9]+[.]*[a-zA-Z0-9]*[@][a-zA-Z]+[.]?[a-zA-Z]+[.][a-zA-Z]*$";

        // this expression for mobile number UC4
        const string expression3 = "^[0-9]{2}[ ][0-9]{10}$";

        // This expression for password UC5 PASSWORD LENGTH
        const string expression4= "^[A-Za-z0-9][!@#$%^&*][a-zA-Z0-9]{8}$"; // e.g-Amol@123

        // this expression for UC6 at least-1 Upper Case
        const string expression5 = "^([A-Z]{1})+[!@#$%^&*a-zA-Z0-9]{7}$"; //exp-A@abc112

        //this expression for UC7 at least-1 numeric number
        const string expression6 = "^([0-9]{1})+[A-Za-z!@#$%^&*]{7}$"; //exp-4Amol@*

        //this expression for UC8Has exactly-1 Special Character
        const string expression7 = "^[A-Za-z0-9]{1,4}[!@#$%^&*]{1}[a-zA-Z0-9]{1,3}$";
        public bool FirstName(string input)
        {
            if (Regex.IsMatch(input, expression))
            {
                Console.WriteLine("FirstName is correct");
                return false;
            }
            else
            {
                Console.WriteLine("FirstName regex failed");
                return true;
            }
        }
        public bool LastName(string input)
        {
            if (Regex.IsMatch(input, expression))
            {
                Console.WriteLine("LastName is correct");
                return false;
            }
            else
            {
                Console.WriteLine("LastName regex failed");
                return true;
            }
        }
        public bool mail(string input)
        {
            if (Regex.IsMatch(input, expression2))
            {
                Console.WriteLine("mail is correct");
                return false;
            }
            else
            {
                Console.WriteLine("mail regex failed");
                return true;
            }
        }
        public bool mobile(string input)
        {
            if (Regex.IsMatch(input, expression3))
            {
                Console.WriteLine("Mobile Number is correct");
                return false;
            }
            else
            {
                Console.WriteLine("Mobile Number regex failed");
                return true;
            }

        }
        public bool Password(string input)
        {
            if (Regex.IsMatch(input, expression4))
            {
                Console.WriteLine("Password is correct");
                return false;
            }
            else
            {
                Console.WriteLine("Password regex failed");
                return true;
            }
        }
        public bool PasswordUpper(string input)
        {
            if (Regex.IsMatch(input, expression5))
            {
                Console.WriteLine("Password is correct");
                return false;
            }
            else
            {
                Console.WriteLine("Password regex failed");
                return true;
            }
        }
        public bool Passwordnumeric(string input)
        {
            if (Regex.IsMatch(input, expression6))
            {
                Console.WriteLine("Password is correct");
                return false;
            }
            else
            {
                Console.WriteLine("Password regex failed");
                return true;
            }
        }
        public bool Passwordchar(string input)
        {
            if (Regex.IsMatch(input, expression7))
            {
                Console.WriteLine("Password is correct");
                return false;
            }
            else
            {
                Console.WriteLine("Password regex failed");
                return true;
            }
        }

}

