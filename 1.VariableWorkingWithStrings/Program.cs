using System;

namespace _1.VariableWorkingWithStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            var userNameValue = Console.ReadLine();

            Console.WriteLine("Hello " + userNameValue + ", Welcome to ITLA");

        }
    }
}
