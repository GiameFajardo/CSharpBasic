using System;

namespace _13.IfStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anyValue = 4;
            string message = "";
            if (anyValue == 13)
            {
                message = "The value is 13!";

            } else if (anyValue > 13)
            {
                message = "The value greater than 13!";

            }
            else
            {
                message = "The value is less than 13.";
            }

            Console.WriteLine(message);
        }
    }
}
