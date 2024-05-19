using System.Security.Cryptography;

namespace Instrukcje_sterujące_i_pętle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Zadanie 1
                Utwórz dwie zmienne typu int o nazwach n1 i n2. Przypisz do nich liczby 10 i 20.
                Używając instrukcji if sprawdź wartości tych zmiennych i wypisz w konsoli, która z liczb jest większa lub czy są równe.
                Tekst powinien się wyświetlić według wzoru n1 jest większe od n2 lub n1 jest równe n2.
             */
            int n1 = 10;
            int n2 = 20;

            if (n1 > n2) { Console.WriteLine("n1>n2"); }
            else if (n1 == n2) { Console.WriteLine("n1=n2"); }
            else { Console.WriteLine("n1<n2"); }

            /*
            Zadanie 2
                Stwórz pętlę, która 10 razy wypisze w konsoli C#.
                Zadanie rozwiąż używając pętli for oraz pętli while.
                W sumie w konsoli wyraz C# powinien pojawić się 20 razy.
            */
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("C#");
            }

            int j = 0;
            int count = 10;
            do
            {
                j = j + 1;
                Console.WriteLine("C#");
            } while (j < count);


            /*
            Zadanie 3
                Stwórz zmienną o nazwie n, które będzie zainicjowana wartością 10.
                Następnie wypisz w konsoli informacje czy liczba jest parzysta, czy nie, dla liczb od 0 do n. Wzór:
                0 - Parzysta
                1 - Nieparzysta
                2 - Parzysta
                itd...
            Jak sprawdzić czy liczba jest parzysta? Podpowiedź: modulo.             
             */
            int n = 10;
            for (int i = 0; i < n + 1; i++)
            {
                if (i % 2 == 0) { Console.WriteLine(i + " - Parzysta"); }
                else { Console.WriteLine(i + " - Nieparzysta"); }
            }

            /*
             Zadanie 4 *dodatkowe
                Stwórz zmienną o nazwie n, która będzie zawierała wartość 5.
                Następnie napisz skrypt, który wypisze w konsoli poniższy schemat.
                Schemat dla n = 5.
                *
                * *
                * * *
                * * * *
                * * * * *
             */
            Console.WriteLine("Podaj liczbe:");
            string liczba_tekst = Console.ReadLine();
            int liczba = Convert.ToInt32(liczba_tekst);
            string tekst = "";
            for (int i = 0; i < liczba; i++)
            {
                if (i == 0) { tekst = "*"; }
                else { tekst = tekst + " *"; }
                Console.WriteLine(tekst);
            }

            /*
            Zadanie 5 * dodatkowe
                Utwórz zmienną exam, która będzie zawierała wartość od 0 do 100.
                Zmienna exam przechowuje wyniki egzaminu.
                Utwórz kod, który wyświetli w konsoli ocenę z testu na podstawie zmiennej point, według poniższego schematu.
                0 - 39 pkt - Ocena Niedostateczna
                40 - 54 pkt - Ocena Dopuszczająca
                55 - 69 pkt - Ocena Dostateczna
                70 - 84 pkt - Ocena Dobra
                85 - 98 pkt - Ocena Bardzo Dobra
                99 - 100 pkt - Ocena Celująca
                W przypadku gdy wartość exam jest mniejsza od 0 lub większa od 100 wyświetl komunikat: Wartość poza zakresem.
                Przykład: Dla point z wartością 57, w konsoli powinno wyświetlić się Ocena Dostateczna.
            */

            Console.WriteLine("Podaj liczbe punktow:");
            string liczba_punktow = Console.ReadLine();
            int exam = Convert.ToInt32(liczba_punktow);
            if (exam < 0) { Console.WriteLine("Wartosc poza zakresem"); }
            else if (exam < 40) { Console.WriteLine("Ocena Niedostateczna"); }
            else if (exam < 55) { Console.WriteLine("Ocena Dopuszczajaca"); }
            else if (exam < 70) { Console.WriteLine("Ocena Dostateczna"); }
            else if (exam < 85) { Console.WriteLine("Ocena Dobra"); }
            else if (exam < 99) { Console.WriteLine("Ocena Bardzo Dobra"); }
            else if (exam <= 100) { Console.WriteLine("Ocena Celujaca"); }
            else { Console.WriteLine("Wartosc poza zakresem"); }
        }
    }
}
