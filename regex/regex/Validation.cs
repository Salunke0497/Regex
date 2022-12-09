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
       const string PinCode = "^[0-9]{6}$";
        public void Test(string input)
        {
         if (Regex.IsMatch(input, PinCode))
            Console.WriteLine("PinCode is correct");
         else
            Console.WriteLine("PinCode regex failed");
        }
    }
}
