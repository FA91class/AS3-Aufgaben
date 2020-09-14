using System;
using Schul_Projekt.helper;

namespace Schul_Projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Aufgabe 1
            /*  Aufgabe1.Programmhinweis();
            Aufgabe1.Run(); */

            // Aufgabe 3
            // Aufgabe3.Run();

            // ISBN Prüfung
            // 3-449-13599-X
            // 978-3-12-732320-7
            // ISBNPrüfer.isbnPrüferDialog();

            // Aufgabe 7.  Generische Typen
            // GenerischeMethoden<string>.GetType("Jo");

            // Aufgabe 8 UseParams
            GenerischeMethoden<int>.UseParams(1, 2, 3, 4);
            GenerischeMethoden<int>.UseParams(new int[] { 5, 6, 7, 8, 9});
            GenerischeMethoden<object>.UseParams(new object[] { 2, 'b', "test", "again"});
            GenerischeMethoden<string>.UseParams("Fisch", "Brot", "Kajüte");

            Console.ReadLine();
        
        }
    }
}
