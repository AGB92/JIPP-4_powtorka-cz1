using Library.Domain;
using Library.Persistence;
using System.Diagnostics;

namespace Library.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zadanie 1
                Book book = new Book("Paragraf 22","Joseph Heller",1961, "978-83-798-5503-2", 5, 18.99m);
                BooksRepository repository = new BooksRepository();

            //zadanie 2
                Console.WriteLine("\nPodaj login:");
                string login = Console.ReadLine();

                Console.WriteLine("\nPodaj hasło:");
                string haslo = Console.ReadLine();

                if (login == "Admin" && haslo == "password")
                {
                    Console.WriteLine("Access Granted");
                }
                else
                {
                    Console.WriteLine("Access Denied");
                }

            //Zadanie 3: Utworzenie menu w aplikacji konsol / Pętle sterujące
                

        }
    }
}
