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

            //do
            //{
            //    Console.WriteLine("ENTER THE FIRST NAME");
            //    string input = Convert.ToString(Console.ReadLine());
            //    flag = Code.FirstName(input);
            //} while (flag == true);

            ////UC2 LAST NAME

            //do
            //{
            //    Console.WriteLine("ENTER THE LAST NAME");
            //    string input = Convert.ToString(Console.ReadLine());
            //    flag = Code.LastName(input);
            //} while (flag == true);

            //UC3 mail-id

            //do
            //{
            //    Console.WriteLine("ENTER THE E-Mail");
            //    Console.WriteLine("formate--abc.xyz@bl.co.in");
            //    string input = Convert.ToString(Console.ReadLine());
            //    flag = Code.mail(input);
            //} while (flag == true);

            //UC4 Mobile Number
            //do
            //{
            //    Console.WriteLine("ENTER THE Mobile Number");
            //    string input = Convert.ToString(Console.ReadLine());
            //    flag = Code.mobile(input);
            //} while (flag == true);

            //UC5 PASSWORD LENGTH
            //do
            //{
            //    Console.WriteLine("ENTER THE PASSWORD HERE");
            //    string input = Convert.ToString(Console.ReadLine());
            //    flag = Code.Password(input);
            //} while (flag == true);

            //UC6 atleast one upper case
            //do
            //{
            //    Console.WriteLine("ENTER THE PASSWORD HERE");
            //    string input = Convert.ToString(Console.ReadLine());
            //    flag = Code.PasswordUpper(input);
            //} while (flag == true);

            //UC7 numeric
            //do
            //{
            //    Console.WriteLine("ENTER THE PASSWORD HERE");
            //    string input = Convert.ToString(Console.ReadLine());
            //    flag = Code.Passwordnumeric(input);
            //} while (flag == true);
            //Console.ReadLine();

            //UC8 special character
            do
            {
                Console.WriteLine("ENTER THE PASSWORD HERE");
                string input = Convert.ToString(Console.ReadLine());
                flag = Code.Passwordchar(input);
            } while (flag == true);
            Console.ReadLine();
        }
    }
}
        
