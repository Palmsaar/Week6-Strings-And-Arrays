using System;

namespace UserName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name");
            string UserFirstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name");
            string UserLastName = Console.ReadLine();
            if (UserFirstName.Length > UserLastName.Length)
            {
                Console.WriteLine("Your first name is longer than your last name!");
            }
            else if (UserFirstName.Length < UserLastName.Length)
            {
                Console.WriteLine("Your first name is shorter than your last name!");
            }
            else
            {
                Console.WriteLine("Your first name is the same length as your last name!");
            }


        }
    }
}
