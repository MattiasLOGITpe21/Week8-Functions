using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisestage eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("sisestage perekonnanimi:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Mis aastal te sündisite?");
            int birthYear = Convert.ToInt32(Console.ReadLine());



            Greetings(firstName, birthYear, lastName);
        }

        private static void Greetings(string someString, int someInt, string otherString)
        {
            Console.WriteLine($"Tere {someString} {otherString}!");
            Console.WriteLine($"Oled {2021 - someInt} aastat vana");
        }

    }
}
