using System;

namespace StringsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name");
            string NameFirst = Console.ReadLine();

            Console.WriteLine($"Your name is {NameFirst.Length} caractercs long!");
        }
    }
}
