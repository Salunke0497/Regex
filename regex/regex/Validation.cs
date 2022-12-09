using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace regex
{
    internal class Validation
    {
       const string expression = "^[A-Z][a-zA-Z]{3,}$";
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

    }
}

