using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string HelloWorld = "Hello World!";
            string PartToLookFor = "hello";

            bool isThere;

            isThere = HelloWorld.ToLower().Contains(PartToLookFor);
            if (isThere)
            {
                Console.WriteLine($"Found {PartToLookFor}!");
            }
            else
            {
                Console.WriteLine($"Din't find {PartToLookFor}!");
            }
        }
    }
}
