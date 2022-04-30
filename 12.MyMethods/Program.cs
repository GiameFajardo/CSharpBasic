using System;

namespace _12.MyMethods
{
    internal class Program
    {
        public static void IntegerAddition(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
        }
        public static int IntegerMultiplication(int a, int b)
        {
            int result = a * b;
            return result;
        }

        public static float IntegerDivision(int a, int b)
        {
            float result = (float)a / b;
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var multiplicationResult = IntegerDivision(48, 57);
            Console.WriteLine(multiplicationResult);
        }

        
    }
}
