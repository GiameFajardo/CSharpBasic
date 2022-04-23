using System;

namespace _6.RelationalOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             == != > < >= <=
            */
            int value1 = 45;
            int value2 = 18;
            int value3 = -18;

            bool result1 = value1 == value2;
            Console.WriteLine("The result of "+value1+" == "+value2+" is: "+ result1);

            bool result2 = value1 != value2;
            Console.WriteLine("The result of "+value1+" != "+value2+" is: " + result2);

            bool result3 = value1 > value2;
            Console.WriteLine("The result of "+value1+" > "+value2+" is: " + result3);

            bool result4 = value1 < value2;
            Console.WriteLine("The result of " + value1 + " < " + value2 + " is: " + result4);

            bool result5 = value1 >= value2;
            Console.WriteLine("The result of " + value1 + " >= " + value2 + " is: " + result5);

            bool result6 = value1 <= value2;
            Console.WriteLine("The result of " + value1 + " <= " + value2 + " is: " + result6);












        }
    }
}
