using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class Email_All
    {
        public string Email()
        {
            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();
            var pattern = "^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\\.[a-zA-Z0-9-]+)*$";
            Regex regex = new Regex(pattern);
            if(regex.IsMatch(email))
            {
                Console.WriteLine(email + "Email is valid");
                return email;
            }
            else
            {
                Console.WriteLine(email + "Email is invalid");
                return email;
            }
        }
    }
}
