using Library.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Persistence
{
    public class BooksRepository
    {
        private readonly List<Book> _database=new List<Book>();
        public BooksRepository() 
        {
            Book b1=new Book("Stary człowiek i morze", "Ernest Hemingway", 1986, "AAAA", 10, 19.99m);
            Book b2=new Book("Komu bije dzwon", "Ernest Hemingway", 1997, "BBBB", 0, 119.99m);
            Book b3=new Book("Alicja w krainie czarów", "C.K. Lewis", 1998, "CCCC", 53, 39.99m);
            Book b4 = new Book("Opowieści z Narnii", "C.K. Lewis", 1999, "DDDD", 33, 49.99m);
            Book b5 = new Book("Harry Potter", "J.K. Rowling", 2000, "EEEE", 23, 69.99m);
            Book b6 = new Book("Paragraf 22", "Joseph Heller", 2001, "FFFF", 5, 45.99m);
            Book b7 = new Book("Lalka", "Bolesław Prus", 2002, "GGGG", 7, 76.99m);
            Book b8 = new Book("To", "Stephen King", 2003, "HHHH", 2, 12.99m);
            Book b9 = new Book("Idiota", "Fiodor Dostojewski", 1950, "IIII", 89, 25.99m);
            Book b10 = new Book("Mistrz i Małgorzata", "Michaił Bułhakow", 1965, "JJJJ", 41, 36.99m);
            _database.Add(b1);
            _database.Add(b2);
            _database.Add(b3);
            _database.Add(b4);
            _database.Add(b5);
            _database.Add(b6);
            _database.Add(b7);
            _database.Add(b8);
            _database.Add(b9);
            _database.Add(b10);
        }

        public void Insert(Book book)
        {
            _database.Add(book);
        }
        public List<Book> GetAll()
        {
            return _database;
        }
        public void RemoveByTitle(string title)
        {
            Book BookToRemove = _database.First(x => x.Title == title);
            _database.Remove(BookToRemove);
        }


        public void ChangeState(string title, int StateChange)
        {
            Book BookToChange = _database.First(x => x.Title == title);
            BookToChange.ProductsAvailable += StateChange;
        }



    }
}
