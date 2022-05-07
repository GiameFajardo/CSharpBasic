using System;

namespace WhileStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueSoftwareExecution = false;

            //while (continueSoftwareExecution)
            //{
            //    Console.WriteLine("The software is working.");
            //    int keepWorking = 0;
            //    Console.WriteLine("Do you want the software to keep working? 1 = yes | 0 = no");
            //    keepWorking = int.Parse(Console.ReadLine());
            //    if (keepWorking == 0)
            //    {
            //        continueSoftwareExecution = false;
            //    }
            //}

            do
            {
                Console.WriteLine("The software is working.");
                int keepWorking = 0;
                Console.WriteLine("Do you want the software to keep working? 1 = yes | 0 = no");
                keepWorking = int.Parse(Console.ReadLine());
                if (keepWorking == 0)
                {
                    continueSoftwareExecution = false;
                }
                else
                {
                    continueSoftwareExecution = true;
                }

            } while (continueSoftwareExecution);
        }
    }
}
