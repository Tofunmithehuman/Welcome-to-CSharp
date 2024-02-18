using System;

namespace WelcomeToCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C#");
            Console.WriteLine("What is your name?");
            string? name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
        }
    }
}