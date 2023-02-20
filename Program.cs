namespace UserRegistrationProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration");
            bool flag = true;
            while(flag = true)
            {
                Console.WriteLine("1. Enter First Name\n2. Enter Last Name\n3. Enter Email Address\n4. Enter Phone Number\n5. Enter Password\n6. Enter Any Email");
                int commmand = Convert.ToInt32(Console.ReadLine());
                switch (commmand)
                {
                    case 1:
                        FirstName firstname = new FirstName();
                        firstname.First();
                        break;
                    case 2:
                        LastName lastname = new LastName();
                        lastname.Last();
                        break;
                    case 3:
                        EmailAddress emailaddress = new EmailAddress();
                        emailaddress.Email();
                        break;
                    case 4:
                        PhoneNumber phonenumber = new PhoneNumber();
                        phonenumber.Phone();
                        break;
                    case 5:
                        Password password = new Password();
                        password.ValidPassword();
                        break;
                    case 6:
                        Email_All email = new Email_All();
                        email.Email();
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;

                }
            }
        }
    }
}