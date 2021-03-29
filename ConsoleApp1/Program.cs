using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello There! Whats your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("Your name is " + userName + "? Nice to meet you!");
            Console.ReadKey();
            Console.WriteLine("See You Later, " + userName + "!");
            Console.ReadKey();

        }// Like This?
    }
}