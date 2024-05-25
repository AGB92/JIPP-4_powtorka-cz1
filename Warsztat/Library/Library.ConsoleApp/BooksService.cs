using Library.Domain;
using Library.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConsoleApp
{
    public class BooksService
    {
        BooksRepository _repository;
        public BooksService(BooksRepository books_repository)
        {
            _repository = books_repository;
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

            Book new_book = new Book(title, author, publicationYear, isbn, productsAvailable, price);
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
}
