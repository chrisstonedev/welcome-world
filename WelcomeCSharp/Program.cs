using System;

namespace WelcomeCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and Welcome to C#!");
            Console.Write("Please tell me your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
            Console.ReadLine();
        }
    }
}
