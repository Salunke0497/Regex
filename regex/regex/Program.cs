using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace regex
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("regex Experssion");
            Console.WriteLine("-------------");
            Validation Code = new Validation();

            string input = "A40220";
            Code.Test(input);

            Console.ReadLine();
        }
    }
}
