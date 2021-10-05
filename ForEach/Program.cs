using System;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string Streng = "Streng";
            int counter = 0;
            foreach (char c in Streng)
            {
                counter++;
            }
            Console.WriteLine($"{Streng} is {counter} character(s) long");
        }
    }
}
