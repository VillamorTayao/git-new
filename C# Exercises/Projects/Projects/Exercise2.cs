using System;

namespace Projects
{
    class Exercise2
    {
        // A Project that 
        static void Main(string[] args)
        {
            string[] usernames = {"villamor123", "good_boy123", "default_user"};
            string[] passwords = {"bioman123", "123456", "villamor123"};
            bool match = false;

            Console.Write("Enter Username: ");
            string input1 = Console.ReadLine();

            Console.Write("Enter Password: ");
            string input2 = Console.ReadLine();

            for (int i = 0; i < usernames.Length; i++)
            {
                if (input1.Equals(usernames[i]) && input2.Equals(passwords[i]))
                {
                    match = true;
                    Console.WriteLine("Welcome" + usernames[i]);
                    break;
                }
            }

            if (!match)
            {
                Console.WriteLine("Account Not Found!");
            }
        }
    }
}
