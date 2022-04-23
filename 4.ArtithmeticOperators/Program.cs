using System;

namespace _4.ArtithmeticOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arithmetic Operators
            // * / - + % -- ++

            // rectangle area calc.

            // rectangle values
            float sideA = 10;
            int sideB = 20;
            sideB++;
            sideB++;
            sideB++;
            sideB++;
            sideB--;
            // rectangle formula is a*b
            float area = sideA * sideB;

            Console.WriteLine("The area of the rectangle is: " + area);
        }
    }
}
