using System;
using System.Collections.Generic;

namespace _9.Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> empanadasShoppingList = new List<string>();

            empanadasShoppingList.Add("Cinco de pizza");
            empanadasShoppingList.Add("Dos de Pollo");
            empanadasShoppingList.Add("Tres de queso");


            for (int i = 0; i < empanadasShoppingList.Count; i++)
            {

                Console.WriteLine(empanadasShoppingList[i]);
            }

            empanadasShoppingList.Remove("Cinco de pizza");
            empanadasShoppingList.Remove("Dos de pollo");


            empanadasShoppingList.RemoveAt(1);

            for (int i = 0; i < empanadasShoppingList.Count; i++)
            {
                Console.WriteLine(empanadasShoppingList[i]);
            }

        }
    }
}
