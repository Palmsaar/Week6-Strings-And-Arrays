using System;

namespace FullNameReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Please enter your full name");
            string FullName = Console.ReadLine();
            for (int i = FullName.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(FullName[i]);
            }*/
            Console.WriteLine("Enter first name!");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last name!");
            string LastName = Console.ReadLine();

            string FullName = FirstName + " " + LastName;
            for (int i = FullName.Length - 1; i >= 0; i--)
            {
                Console.Write(FullName[i]);
            }
        }
    }
}
