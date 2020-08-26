using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Schul_Projekt.helper
{
    class Aufgabe1
    {
        public static void Programmhinweis()
        {
            Console.WriteLine("Hinweis:");
            Console.WriteLine("Das Programm addiert 2 eingegebene Zahlen. ");
        }

        public static double Input()
        {
            Console.WriteLine("Bitte gib eine Zahl ein: ");
            Console.Write("$ ");
            double result = Convert.ToDouble(Console.ReadLine());
            return result;
        }

        public static double Verarbeitung(double one, double two)
        {
            double result = one + two;
            return result;
        }

        // Methodenkopf
        public static /*Rückgabetype ->*/void Ausgabe(double sum, double one, double two) // Parameter | Formale Parameter
        {
            // Methodenrumpf
            Console.WriteLine("Ergebnis der Addition");
            Console.WriteLine(sum + " = " + one + " + " + two); // Argumente bzw aktuelle Parameter
        }

        public static void Run()
        {
            double one = Input(); // Methodenaufruf
            double two = Input();

            double result = Verarbeitung(one, two);

            Ausgabe(result, one, two);
        }
    }
}
