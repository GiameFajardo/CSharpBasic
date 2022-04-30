using System;

namespace _8.Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tiposDeCafe;
            float[] precioDeCafe;

            tiposDeCafe = new string[] { "Negro", "Latte", "Mocachino", "Capichino" };
            precioDeCafe = new float[] { 80,      110,     100,         100 };

            tiposDeCafe[0] = "Largo";
            for (int i = 0; i < tiposDeCafe.Length; i++)
            {
                Console.WriteLine($"producto: {tiposDeCafe[i]} \t ${precioDeCafe[i]} ");
            }
        }
    }
}
