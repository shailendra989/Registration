using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    internal class EmailAddress
    {
        public void Email()
        {
            Console.WriteLine("Enter User Email Address");
            var data = Console.ReadLine();
            string pattern = "^[0-9A-Za-z]+([.][0-9A-Za-z]+)?[@][0-9A-Za-z]+[.][a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(data))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(data + " It is a Valid Email Address");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(data + " It is a Invalid Email Address");
                Console.ResetColor();
            }
        }
    }
}
