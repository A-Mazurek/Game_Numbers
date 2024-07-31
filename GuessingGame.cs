using System;

namespace GraZGadywanieLiczby
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int wylosowanaLiczba = random.Next(1, 101); // Losowanie liczby od 1 do 100
            int proba = 0;
            int liczbaUzytkownika = 0;
            bool zgadles = false;

            Console.WriteLine("Witaj w grze 'Zgadywanie liczby'!");
            Console.WriteLine("Komputer wylosował liczbę od 1 do 100. Spróbuj ją odgadnąć.");

            while (!zgadles)
            {
                Console.Write("Podaj swoją liczbę: ");
                string input = Console.ReadLine();

                // Sprawdzenie, czy użytkownik podał prawidłową liczbę
                if (int.TryParse(input, out liczbaUzytkownika))
                {
                    proba++;

                    if (liczbaUzytkownika < wylosowanaLiczba)
                    {
                        Console.WriteLine("Wylosowana liczba jest większa. Spróbuj ponownie.");
                    }
                    else if (liczbaUzytkownika > wylosowanaLiczba)
                    {
                        Console.WriteLine("Wylosowana liczba jest mniejsza. Spróbuj ponownie.");
                    }
                    else
                    {
                        Console.WriteLine($"Gratulacje! Odgadłeś liczbę {wylosowanaLiczba} w {proba} próbach.");
                        zgadles = true;
                    }
                }
                else
                {
                    Console.WriteLine("Podana wartość nie jest liczbą. Spróbuj ponownie.");
                }
            }

            Console.WriteLine("Dziękuję za grę!");
        }
    }
}


//use to compile code: https://www.onlinegdb.com/online_csharp_compiler

