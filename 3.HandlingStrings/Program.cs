using System;

namespace _3.HandlingStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height = 184;
            int age = 30;
            string name = "Giame Fajardo";

            string information = "You are registred with the following info. \n Name " + name + "\n Height: " + height + "\n Age: " + age;

            Console.WriteLine(information);
        }
    }
}
