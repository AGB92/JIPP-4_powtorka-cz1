namespace Pierwszy_program_rozgrzewka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            /*
             Pierwszy program - rozgrzewka
                 Zadanie 1
                    Stwórz nowy projekt typu Console App (.Net Core).
                Zadanie 2
                W metodzie Main umieść następujący kod:
                    Console.WriteLine("Podaj swoje imię:");
                    var name = Console.ReadLine();
                    Console.WriteLine("Hello " + name);
                    Uruchom projekt, wyświetli się okno konsoli.
                Zadanie 3
                    W metodzie Main umieść następujący kod:
                    int result = 5 + 9
                    Uruchom projekt.
                    Jeśli uruchomienie zakończy się niepowodzeniem, znajdź i napraw błąd. Błędy możesz zobaczyć w oknie Error List.
            */
            Console.WriteLine("Podaj swoje imię:");
            var name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            int result = 5 + 9;  //wartosc nigdy nie zostala uzyta wiec wypisze ja ponizej
            Console.WriteLine("\n" + result);

        }
    }
}
