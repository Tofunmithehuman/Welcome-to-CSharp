using System;

namespace WelcomeToCSharp
{
    internal class Program
    {
        // Checks if user is admin by checking if name is the expected value
        public static void checkIsAdmin()
        {
            Console.WriteLine("What is your name?");
            string? name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            if ((name == "Oluwatofunmi") || (name == "oluwatofunmi"))
            {
                Console.WriteLine(name + " is an Admin");
            }
            else
            {
                Console.WriteLine(name + " is not an Admin");
            }

        }
        // Add two integer values
        public static void add(int a, int b)
        {
            double sum = a + b;
            Console.WriteLine(sum);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C#");
            checkIsAdmin();
            add(10, 3);
        }
    }
}