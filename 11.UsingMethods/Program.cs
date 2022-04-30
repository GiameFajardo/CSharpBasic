using System;

namespace _11.UsingMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string courseTopic = "C# Basico";
            string institution = "ITLA";

            string message = $"Estoy aprendiendo de {courseTopic} en {institution}.";

            Console.WriteLine(message);


            //CLONE
            string insitutionClone = institution.Clone().ToString();
            insitutionClone = insitutionClone + "Clone";
            institution = institution + "Original";
            string newInstitution = "ITLAOriginal";
            //Console.WriteLine(insitutionClone);
            //Console.WriteLine(institution);

            //CompareTo

            //Console.WriteLine(institution.CompareTo(courseTopic));
            //Console.WriteLine(institution.CompareTo(insitutionClone));
            //Console.WriteLine(institution.CompareTo(newInstitution));
            //Console.WriteLine(institution == newInstitution);
            //Console.WriteLine(institution == insitutionClone);

            //Contains

            Console.WriteLine(message.Contains("Insti"));


            Console.WriteLine(message.EndsWith("ITLA."));


            Console.WriteLine(message.StartsWith("ITLA."));


            //IndexOf
            Console.WriteLine(message.IndexOf('I'));
            Console.WriteLine(message.IndexOf("ITLA"));

            // ToLower ToUpper
            Console.WriteLine(message.ToLower());
            Console.WriteLine(message.ToUpper());

            Console.WriteLine(message.ToUpper() == message.ToLower());
            string text1 = "Hola";
            string text2 = "HOLA";
            Console.WriteLine(text1.ToLower() == text2.ToLower());

            //Insert
            Console.WriteLine(message.Insert(34, "en el mejor intituto: "));

            //LastIndexOf
            Console.WriteLine(message.LastIndexOf("e"));

            //Remove
            //Console.WriteLine(message.Remove(34));
            //string messageWithoutInstitution = message.Remove(34, 4);
            //Console.WriteLine(messageWithoutInstitution.Insert(34, "Instituto Tecnologico de las Americas"));

            //Replace
            Console.WriteLine(message.Replace("ITLA", "Instituto Tecnologico de las Americas"));

            //Split
            string[] words = message.Split(" ");
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
            //Substring
            Console.WriteLine(message.Substring(34));
            Console.WriteLine(message.Substring(34,4));

            //ToCharArray
            char[] caracters = message.ToCharArray();
            for (int i = 0; i < caracters.Length; i++)
            {
                Console.WriteLine(caracters[i]);
            }


            string dirtyMessage = "   Estoy aprendiendo de C# Basico en ITLA.  ";
            Console.WriteLine(dirtyMessage);
            Console.WriteLine(dirtyMessage.Trim());

        }
    }
}
