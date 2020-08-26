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

            if (input.Length != length)
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
                check = input.Last();
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
            isbnString = isbnString.Replace("-", "").Replace(" ", "");
            int i;
            int result;
            ISBN_model isbn = new ISBN_model();
            ISBN_model validIsbn = validateLength(isbnString, (isbnString.Length - 1), isbn);

            switch (validIsbn.mode)
            {
                case 9:
                    i = 1;
                    result = 0;
                    foreach (char c in isbn.number)
                    {
                        result = i * c + result;
                        i++;
                    }
                    result %= 11;
                    if (result != validIsbn.checkField)
                    {
                        validIsbn.isValid = false;
                    }                   
                    return validIsbn;
                case 12:
                    result = validIsbn.number[0]
                        + validIsbn.number[2]
                        + validIsbn.number[4]
                        + validIsbn.number[6]
                        + validIsbn.number[8]
                        + validIsbn.number[10]
                        + 3
                        * (
                        validIsbn.number[1] +
                        validIsbn.number[3] +
                        validIsbn.number[5] +
                        validIsbn.number[7] +
                        validIsbn.number[11]
                        );
                    result %= 10;
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
                Console.WriteLine("Die ISBN ist Korrekt: " + check.number + " " + check.checkField);
            }
            else
            {
                Console.WriteLine("Die ISBN ist nicht Korrekt: " + check.number + " " + check.checkField);
            }
        }
    }
}
