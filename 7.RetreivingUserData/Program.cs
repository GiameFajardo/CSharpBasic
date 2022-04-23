using System;

namespace _7.RetreivingUserData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //rectangle area calc.
            Console.WriteLine("Introduce side A: ");
            float sideA = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce side B: ");
            float sideB = float.Parse(Console.ReadLine());

            // rectangle formula i s a*b
            var area = sideA * sideB;

            Console.WriteLine("The area of the rectangle is: " + area);

        }
    }
}
