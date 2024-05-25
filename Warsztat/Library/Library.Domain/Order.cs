using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain
{
    public class Order
    {
        DateTime Date { get; set; }
        public List<BookOrdered> BooksOrderedList { get; set; }
        public Order()
        {
            Date = DateTime.Now;
            BooksOrderedList = new List<BookOrdered>();
        }
        public override string ToString()
        {
            string str1 = "";
            string str2 = "";

            str1 = $"Order: {Convert.ToString(Date)}";

            foreach (BookOrdered ksiazka in BooksOrderedList)
            {
                str1 += $"\nBook: {Convert.ToString(ksiazka.BookID)} Count: {Convert.ToString(ksiazka.NumerOrdered)}";
            }

            return str1 + str2;
        }
    }
}
