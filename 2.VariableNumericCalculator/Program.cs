using System;

namespace _2.VariableNumericCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int result;

            Console.WriteLine("Enter the first number: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            
            result = number1 * number2;

            Console.WriteLine("The result is: " + result);
        }
    }
}
