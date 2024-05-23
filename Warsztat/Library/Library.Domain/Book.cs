using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }
        public string ISBN { get; set; }
        public int ProductsAvailable { get; set; }
        public decimal Price { get; set; }
        public Book() { }
        public Book(string title, string author, int publicationYear, string isbn, int productsAvailable, decimal price)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            PublicationYear = publicationYear;
            ProductsAvailable = productsAvailable;
            Price = price;
        }

        public override string ToString()
        {
            return $"Title: {Title} Author: {Author} ProductsAvailable: {ProductsAvailable}";
        }
    }
    public class BookOrdered
    {
        public int BookID { get; set; }
        public int NumerOrdered { get; set; }
    }
    public class Order
    {
        DateTime Date { get; set; }
        List<BookOrdered> BooksOrderedList { get; set; }
        public Order() 
        { 
            Date=DateTime.Now;
            BooksOrderedList = new List<BookOrdered>();
        }
        public override string ToString()
        {
            string str1="";
            string str2 = "";

            str1 = $"Order: {Convert.ToString(Date)}";

            foreach (BookOrdered ksiazka in BooksOrderedList)
            {
                str1 +=$"\nBook: {Convert.ToString(ksiazka.BookID)} Count: {Convert.ToString(ksiazka.NumerOrdered)}";
            }

            return str1+str2;
        }
    }
}
