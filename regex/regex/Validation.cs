using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace regex
{
    internal class Validation
    {
        const string expression = "^[A-Z][a-zA-Z]{3,}$";
        const string expression2 = "^[a-zA-Z0-9]+[.]*[a-zA-Z0-9]*[@][a-zA-Z]+[.]?[a-zA-Z]+[.][a-zA-Z]*$";

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

    }
}

