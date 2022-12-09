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
       const string FirstName = "^[A-Z][a-zA-Z]*${3,}";
        public void Test(string input)
        {
         if (Regex.IsMatch(input, FirstName))
            Console.WriteLine("FirstName is correct");
         else
            Console.WriteLine("FirstName regex failed");
        }
    }
}
