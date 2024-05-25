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
            Book book = new Book("Paragraf 22", "Joseph Heller", 1961, "978-83-798-5503-2", 5, 18.99m);
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

            //Zadanie 4 Przed pętlą utwórz obiekt klasy BooksService
                BooksRepository books_repository = new BooksRepository();
                BooksService books_service = new BooksService(books_repository);

            //Utwórz obiekt klasy OrdersRepository przed główną pętlą programu
                OrdersRepository order_repository=new OrdersRepository();
                OrderService order_service = new OrderService(order_repository);

            //Zadanie 3: Utworzenie menu w aplikacji konsol / Pętle sterujące
            string command;
            do
            {
                Console.Clear();
                DisplayMenu();
                command = Console.ReadLine().ToLower();

                Console.Clear();
                switch (command)
                {
                    case "dodaj":
                        books_service.AddBook();
                        break;
                    case "usun":
                        books_service.RemoveBook();
                        break;
                    case "wypisz":
                        books_service.ListBooks();
                        break;
                    case "zmien":
                        books_service.ChangeState();
                        break;
                    case "dodaj zamowienie":
                        order_service.PlaceOrder();
                        break;
                    case "lista zamowien":
                        order_service.ListAll();
                        break;
                    case "wyjdz":
                        // Exit the loop without any message
                        break;
                    default:
                        Console.WriteLine("Podana komenda nie jest wspierana");
                        break;
                }

                if (command != "wyjdz")
                {
                    Console.WriteLine("Press Any Key...");
                    Console.ReadKey();
                }

            } while (command != "wyjdz");
        }

        static void DisplayMenu()
        {
            Console.WriteLine("Mozliwe komendy do wpisania:");
            Console.WriteLine("dodaj - Dodaj książkę");
            Console.WriteLine("usun - Usuń książkę");
            Console.WriteLine("wypisz - Wypisz wszystkie książki");
            Console.WriteLine("zmien - Zmień stan magazynowy książek");
            Console.WriteLine("dodaj zamowienie - Dodaj nowe zamówienie");
            Console.WriteLine("lista zamowien - Wypisz wszystkie zamówienia");
            Console.WriteLine("wyjdz - Zakończ program");
            Console.Write("Wprowadz komendę: ");
        }
    }
}
