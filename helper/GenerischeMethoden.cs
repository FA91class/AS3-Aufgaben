using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Schul_Projekt.helper
{
    class GenerischeMethoden<T>
    {
        private T attribut;
        public static void GetType(T value)
        {
            Console.WriteLine("Der übergebene Datentyp der Variable '" + value + "' ist: \r\n " + typeof(T) + " / \r\n " + value.GetType());
        }

        public static void UseParams(params T[] values)
        {
            foreach (var item in values.Reverse())
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\r\n");
        }
    }
}
