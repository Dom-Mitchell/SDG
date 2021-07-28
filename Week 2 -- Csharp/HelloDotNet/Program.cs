using System;

namespace HelloDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            var name = "Dom Mitchell";
            var userName = "";

            // My Greeting
            Console.WriteLine($"\nHello World, my name is {name}!\n");

            // User Greeting
            Console.WriteLine("What is your name?");
            userName = Console.ReadLine();
            Console.WriteLine($"\nIts a pleasure to meet you, {userName}!\n");
        }
    }
}
