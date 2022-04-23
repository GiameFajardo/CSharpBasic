using System;

namespace _5.LogicalOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            bool value1 = true;
            bool value2 = true;
            bool value3 = false;

            // && || !
            bool result1 = value1 && value2 && value3;
            Console.WriteLine("The result of the logical operator AND is: " + result1);
            bool result2 = value1 || value2 || value3;
            Console.WriteLine("The result of the logical operator OR is: " + result2);
            bool result3 = !value1;
            Console.WriteLine("The result of the logical operator ! is: " + result3);
}
    }
}
