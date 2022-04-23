using System;

namespace _0.DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value1 = -15;
            bool value2 = false;
            float value3 = 17.2f;
            double value4 = 24.5d;
            char value5 = 'r';
            string value6 = "90";
            long value7 = -123;
            uint value8 = 153;

            value3 = value7;
            value1 = (int)value3;
            int result = Convert.ToInt32(value6);
            Console.WriteLine(result);
        }
    }
}
