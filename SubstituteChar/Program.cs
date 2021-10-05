using System;

namespace SubstituteChar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a first name");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Please enter a last name");
            string LastName = Console.ReadLine();
            string FullName = $"{FirstName} {LastName}".ToLower();

            for (int i = 0; i < FullName.Length; i++)
            {
                if (FullName[i] == 'e')
                {
                    Console.Write("#");
                }
                else if (FullName[i] == 'a')
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(FullName[i]);
                }
            }
        }
    }
}
