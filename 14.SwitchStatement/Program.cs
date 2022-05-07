using System;

namespace _14.SwitchStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string option = "";
            option = Console.ReadLine();
            switch (option)
            {
                case "naranja":
                    Console.WriteLine("$20");

                    break;
                case "fresa":
                    Console.WriteLine("$35");
                    break;
                default:
                    Console.WriteLine("Enter a valid Value.");
                    break;
            }

        }
    }
}
