using System;
using System.Collections.Generic;
using System.Text;

namespace Schul_Projekt.helper
{
    class GenerischeMethoden<T>
    {
        private T attribut;
        public static void getType(T value)
        {
            Console.WriteLine("Der übergebene Datentyp der Variable '" + value + "' ist: " + typeof(T));
        }
    }
}
