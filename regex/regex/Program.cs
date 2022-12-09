using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace regex
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool flag;
            Console.WriteLine("regex Experssion");
            Console.WriteLine("-------------");
            Validation Code = new Validation();
            //UC1 first name
            do
            {
                Console.WriteLine("ENTER THE FIRST NAME");
                string input = Convert.ToString(Console.ReadLine());
                flag = Code.FirstName(input);
            } while (flag == true);

            //UC2 LAST NAME
            do
            {
                Console.WriteLine("ENTER THE LAST NAME");
                string input = Convert.ToString(Console.ReadLine());
                flag = Code.LastName(input);
            } while (flag == true);
            Console.ReadLine();
        }
    }
}
        
