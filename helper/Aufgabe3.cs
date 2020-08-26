using System;
using System.Collections.Generic;
using System.Text;

namespace Schul_Projekt.helper
{
    class Aufgabe3
    {
        public static void Welcome()
        {
            Console.WriteLine("Herzlich Willkommen zum Taschenrechner!");
            Console.WriteLine("Diese Möglichkeiten stehen zur verfügung: ");
        }

        public static void Menu()
        {
            Console.Write(
                "---------------------------------\r\n" +
                "$ *        bietet die Möglichkeit zu Multiplizieren\r\n" +
                "$ /        bietet die Möglichkeit zu Dividieren\r\n" +
                "$ +        bietet die Möglichkeit zu Addieren\r\n" +
                "$ -        bietet die Möglichkeit zu Sutrahieren\r\n" +
                "$ random   gibt eine zufällige Zahl zurück\r\n" +
                "$ sinus    bietet die Möglichkeit den Sinus auszurechnen\r\n" +
                "$ cosinus  bietet die Möglichkeit den Cosinus auszurechnen\r\n" +
                "$ menu     zeigt alle Möglichkeiten an\r\n" +
                "$ exit     beendet die Anwendung\r\n" +
                "---------------------------------\r\n"
                );
        }

        public static string Input()
        {
            Console.Write("$ ");
            return Console.ReadLine();
        }

        public static double Calculate(string method)
        {
            switch (method)
            {
                case "random":
                    Random rdn = new Random();
                    return rdn.Next();
                default:
                    return 0.0;
            }
        }

        public static double Calculate(double one, string method)
        {
            one = Convert.ToDouble(one);
            switch (method)
            {
                case "random":
                    
                case "sinus":
                    return Math.Sin(one);
                case "cosinus":
                    return Math.Cos(one);
                default:
                    return 0.0;
            }
        }

        public static double Calculate(double one, double two, string method)
        {
            one = Convert.ToDouble(one);
            two = Convert.ToDouble(two);
            switch (method)
            {
                case "*":
                    return one * two;
                case "+":
                    return one + two;
                case "/":
                    return one / two;
                case "%":
                    return one % two;
                default:
                    return 0.0;
            }

        }

        public static void Run()
        {
            double one;
            double two;
            Welcome();
            Menu();
            string choice = Input();
            while (choice != "exit")
            {
                if (choice == "")
                {
                    choice = Input();
                }

                Console.Clear();
                Welcome();
                Menu();

                switch (choice)
                {
                    case "+":
                        Console.WriteLine("Bitte gib die erste Zahl ein: ");
                        one = Convert.ToDouble(Input());
                        Console.WriteLine("Bitte gib die zweite Zahl ein: ");
                        two = Convert.ToDouble(Input());
                        Console.WriteLine("Das Ergebnis ist: " + Calculate(one, two, choice));
                        break;
                    case "-":
                        Console.WriteLine("Bitte gib die erste Zahl ein: ");
                        one = Convert.ToDouble(Input());
                        Console.WriteLine("Bitte gib die zweite Zahl ein: ");
                        two = Convert.ToDouble(Input());
                        Console.WriteLine("Das Ergebnis ist: " + Calculate(one, two, choice));
                        break;
                    case "*":
                        Console.WriteLine("Bitte gib die erste Zahl ein: ");
                        one = Convert.ToDouble(Input());
                        Console.WriteLine("Bitte gib die zweite Zahl ein: ");
                        two = Convert.ToDouble(Input());
                        Console.WriteLine("Das Ergebnis ist: " + Calculate(one, two, choice));
                        break;
                    case "/":
                        Console.WriteLine("Bitte gib die erste Zahl ein: ");
                        one = Convert.ToDouble(Input());
                        Console.WriteLine("Bitte gib die zweite Zahl ein: ");
                        two = Convert.ToDouble(Input());
                        Console.WriteLine("Das Ergebnis ist: " + Calculate(one, two, choice));
                        break;
                    case "%":
                        Console.WriteLine("Bitte gib die erste Zahl ein: ");
                        one = Convert.ToDouble(Input());
                        Console.WriteLine("Bitte gib die zweite Zahl ein: ");
                        two = Convert.ToDouble(Input());
                        Console.WriteLine("Das Ergebnis ist: " + Calculate(one, two, choice));
                        break;
                    case "sinus":
                        Console.WriteLine("Bitte gib eine Zahl ein: ");
                        one = Convert.ToDouble(Input());
                        Console.WriteLine("Das Ergebnis ist: " + Calculate(one, choice));
                        break;
                    case "cosinus":
                        Console.WriteLine("Bitte gib eine Zahl ein: ");
                        one = Convert.ToDouble(Input());
                        Console.WriteLine("Das Ergebnis ist: " + Calculate(one, choice));
                        break;
                    case "random":
                        Console.WriteLine("Die Zahl ist: " + Calculate("random"));
                        break;
                    case "menu":
                        Menu();
                        break;
                    case "exit":
                        return;
                    default:
                        break;
                }
                choice = "";             
            }
        }
    }
}
