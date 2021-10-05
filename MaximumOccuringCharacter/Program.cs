using System;

namespace MaximumOccuringCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a first name");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Please enter a last name");
            string LastName = Console.ReadLine();
            string FullName = $"{FirstName}{LastName}".ToLower();
            int Countera = 0;
            int Countere = 0;
            int Countert = 0;
            int Counteri = 0;
            int Countero = 0;
            int Countern = 0;
            int Counters = 0;
            int Counterh = 0;
            int Counterr = 0;
            for (int i = 0; i > FullName.Length; i++)
            {
                if (FullName[i] == 'a')
                {
                    Countera++;
                }
                else if (FullName[i] == 'e')
                {
                    Countere++;
                }
                else if (FullName[i] == 't')
                {
                    Countert++;
                }
                else if (FullName[i] == 'i')
                {
                    Counteri++;
                }
                else if (FullName[i] == 'o')
                {
                    Countero++;
                }
                else if (FullName[i] == 'n')
                {
                    Countern++;
                }
                else if (FullName[i] == 's') 
                {
                    Counters++;
                }
                else if (FullName[i] == 'h')
                {
                    Counterh++;
                }
                else if (FullName[i] == 'r')
                {
                    Counterr++;
                }
                else
                {

                }
            }
            
        }
    }
}
