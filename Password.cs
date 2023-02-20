using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    internal class Password
    {
        public void ValidPassword()
        {
            Console.WriteLine("Enter User Password");
            var data = Console.ReadLine();
            string pattern = "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*\\W)(.{8,})$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(data))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(data + " It is a Valid Password");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(data + " It is a Invalid Password");
                Console.ResetColor();
            }
        }
    }
}
