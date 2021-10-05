using System;

namespace ACharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name");
            string LastName = Console.ReadLine();
            string FullName = $"{FirstName}{LastName}".ToLower();
            int Counter = 0;
            /*foreach (char character in FullName)
            {
                if (character == 'a')
                {
                    Counter++;
                }
            }*/
            /*for (int i = 0; i < FullName.Length; i++)
            {
                if (FullName[i] == 'a')
                {
                    Counter++;
                }
            }*/
            int i = FullName.Length - 1;
            while (i >= 0)
            {
                
                if (FullName[i] == 'a')
                {
                    Counter++;
                }
                i--;
            }
             
            Console.WriteLine(Counter);
        }
    }
}
