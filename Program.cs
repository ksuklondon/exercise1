using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zjazd_3_sobota_zad_3
{
    public class Program
    {
        public static string OdwrocSlowa(string wejscie)
        {
            // Podziel wejściowy ciąg na tablicę słów
            string[] slowa = wejscie.Split(' ');

            // Odwróć tablicę słów
            Array.Reverse(slowa);

            // Połącz odwróconą tablicę z powrotem w jeden ciąg
            return string.Join(" ", slowa);
        }

        public static void Main()
        {
            // Poproś użytkownika o wprowadzenie dowolnego tekstu
            Console.WriteLine("Proszę wprowadzić dowolny tekst:");
            string wejscie = Console.ReadLine();

            // Sprawdź, czy wprowadzono niepusty tekst
            if (string.IsNullOrEmpty(wejscie))
            {
                Console.WriteLine("Nie wprowadzono tekstu. Proszę spróbować ponownie.");
            }
            else
            {
                // Przetwórz wprowadzony tekst funkcją OdwrocSlowa
                string odwrocone = OdwrocSlowa(wejscie);

                // Wyświetl oryginalny tekst i jego odwróconą wersję
                Console.WriteLine("Oryginalny tekst: " + wejscie);
                Console.WriteLine("Tekst z odwróconymi słowami: " + odwrocone);
            }

            // Informuj użytkownika, że może zamknąć program
            Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }
    }
}
