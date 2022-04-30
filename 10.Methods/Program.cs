using System;

namespace _10.Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Random rdm = new Random();
            for (int i =0; i < 6; i++)
            {

                Console.WriteLine(rdm.Next(1, 38));
            }
        }
        
    }
}
