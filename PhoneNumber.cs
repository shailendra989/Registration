using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    internal class PhoneNumber
    {
        public void Phone()
        {
            Console.WriteLine("Enter User Phone Number");
            var data = Console.ReadLine();
            string pattern = "^[+][0-9]{1,3}[ ][6-9]{1}[0-9]{9}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(data))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(data + " It is a Valid Phone Number");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(data + " It is a Invalid Phone Number");
                Console.ResetColor();
            }
        }
    }
}
