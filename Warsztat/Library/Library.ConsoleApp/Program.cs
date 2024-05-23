using Library.Domain;
using Library.Persistence;
using System.Diagnostics;

namespace Library.ConsoleApp
{

    /*zadanie 4 klasa book service*/
        public class BooksService
        {
            BooksRepository _repository;
            public BooksService(BooksRepository books_repository)
            {
                _repository=books_repository;
            }
            public void AddBook()
            {
                Console.Write("Podaj tytuł książki: ");
                string title = Console.ReadLine();
                Console.Write("Podaj autora książki: ");
                string author = Console.ReadLine();
                Console.Write("Podaj rok publikacji książki: ");
                int publicationYear = Convert.ToInt32(Console.ReadLine());
                Console.Write("Podaj ISBN książki: ");
                string isbn = Console.ReadLine();
                Console.Write("Podaj ilość dostępnych egzemplarzy: ");
                int productsAvailable = Convert.ToInt32(Console.ReadLine());
                Console.Write("Podaj cenę książki: ");
                decimal price = Convert.ToDecimal(Console.ReadLine());

                Book new_book= new Book(title,author,publicationYear,isbn,productsAvailable,price);
                _repository.Insert(new_book);
            }
            public void RemoveBook()
            {
                Console.Write("Podaj tytuł książki do usunięcia: ");
                string title = Console.ReadLine();
                _repository.RemoveByTitle(title);
            }
            public void ListBooks()
            {
                Console.WriteLine("Tutaj pojawi się lista książek.");
                _repository.GetAll();
                foreach (Book ksiazka in _repository.GetAll())
                {
                    Console.WriteLine(ksiazka.Title);
                }
        }
            public void ChangeState()
            {
                Console.Write("Podaj tytuł książki, której stan ma się zmienić: ");
                string title = Console.ReadLine();
                Console.Write("Podaj zmianę stanu (np. -1 lub 1): ");
                int change = Convert.ToInt32(Console.ReadLine());
                _repository.ChangeState(title, change);
            }
        }
    /*zadanie 4 klasa book service*/

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

            //Zadanie 4 Przed pętlą utwórz obiekt klasy BooksService
               BooksRepository books_repository= new BooksRepository();
               BooksService books_service= new BooksService(books_repository);



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
                        Console.WriteLine("proba dodania nowego zamowienia");
                        break;
                    case "lista zamowien":
                        Console.WriteLine("proba wypisania wszystkich zamowien");
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




    /*
     jestem w zadaniu 6 Orders pkt 4.tego jeszcze nie ma
     4. Przejdz do projektu Library.Persistence
     5. Utworz klasę OrdersRepository
     6. Wewnatrz klasy OrdersRepository utwórz prywatne pole database typu List, które od razu zainicjalizu pustą listą.
     7. Wewnatrz klasy OrdersRepository zaimplementuj dwie metody:
     */
}