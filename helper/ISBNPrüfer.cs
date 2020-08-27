using Schul_Projekt.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Schul_Projekt.helper
{
    class ISBNPrüfer
    {

        private static ISBN_model validateLength(string input, int length, ISBN_model isbn)
        {
            int check;

            if (input.Length != 13 && input.Length != 10)
            {
                isbn.isValid = false;
                isbn.number = null;
                return isbn;
            }

            if (Char.IsLetter(input.Last()))
            {
                check = 10;
            }
            else
            {
                check = Convert.ToInt32(input.Last().ToString());
            }

            isbn.checkField = check;
            isbn.number = input.Remove(input.Length - 1);

            switch (isbn.number.Length)
            {
                case 9:
                    isbn.mode = 9;
                    break;
                case 12:
                    isbn.mode = 12;
                    break;
            }
            isbn.isValid = true;
            return isbn;
}

        private static ISBN_model checkIsbn(string isbnString)
        {
            ISBN_model isbn = new ISBN_model();
            isbn.origin = isbnString;

            isbnString = isbnString.Replace("-", "").Replace(" ", "");
            int i;
            int result;
            
            ISBN_model validIsbn = validateLength(isbnString, (isbnString.Length - 1), isbn);

            switch (validIsbn.mode)
            {
                case 9:
                    i = 1;
                    result = 0;
                    foreach (char c in isbn.number)
                    {
                        result = i * Convert.ToInt32(c) + result;
                        i++;
                    }
                    result %= 11;
                    if (result != validIsbn.checkField)
                    {
                        validIsbn.isValid = false;
                    }                   
                    return validIsbn;
                case 12:
                    result = Convert.ToInt32(validIsbn.number[0].ToString())
                        + Convert.ToInt32(validIsbn.number[2].ToString())
                        + Convert.ToInt32(validIsbn.number[4].ToString())
                        + Convert.ToInt32(validIsbn.number[6].ToString())
                        + Convert.ToInt32(validIsbn.number[8].ToString())
                        + Convert.ToInt32(validIsbn.number[10].ToString())
                        + 3
                        * (
                        Convert.ToInt32(validIsbn.number[1].ToString()) +
                        Convert.ToInt32(validIsbn.number[3].ToString()) +
                        Convert.ToInt32(validIsbn.number[5].ToString()) +
                        Convert.ToInt32(validIsbn.number[7].ToString()) +
                        Convert.ToInt32(validIsbn.number[9].ToString()) +
                        Convert.ToInt32(validIsbn.number[11].ToString())
                        );
                    result %= 10;
                    result = (10 - result) % 10;
                    if (result != validIsbn.checkField)
                    {
                        validIsbn.isValid = false;
                    }
                    return validIsbn;
                default:
                    isbn.isValid = false;
                    return isbn;
            }
           
        }


        public static void isbnPrüferDialog() {
            Console.WriteLine("Herzlich Willkommen zum ISBN Rechner, bitte geben sie eine Nummer ein:");
            ISBN_model check = checkIsbn(Console.ReadLine());
            if (check.isValid)
            {
                Console.WriteLine("Die ISBN " + (check.mode + 1) + " ist Korrekt: " + check.origin);
            }
            else
            {
                Console.WriteLine("Die ISBN ist nicht Korrekt: " + check.origin);
            }
        }
    }
}
