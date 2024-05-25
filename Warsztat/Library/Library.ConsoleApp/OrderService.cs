using Library.Domain;
using Library.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ConsoleApp
{
    public class OrderService
    {
        private OrdersRepository _orderRepository;
        public OrderService(OrdersRepository ordersRepository)
        {
            _orderRepository = ordersRepository;
        }
        public void PlaceOrder()
        {
            Order NewOrder = new Order();
            Console.WriteLine("\nadd - dodaj pozycje do zamowienia \nend - zamnkij zamowienie");
            string str = Console.ReadLine();
            do
            {
                if (str=="add")
                {
                    Console.WriteLine("\nPodaj ID ksiazki");
                    int _ID = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nPodaj Ilosc ksiazek");
                    int _Quantity = Convert.ToInt32(Console.ReadLine());
                    BookOrdered bookOrdered = new BookOrdered();
                    bookOrdered.BookID = _ID;
                    bookOrdered.NumerOrdered = _Quantity;
                    NewOrder.BooksOrderedList.Add(bookOrdered);
                    Console.WriteLine("\n dodac kolejna pozycje?\nadd - dodaj pozycje do zamowienia \nend - zamnkij zamowienie");
                    str = Console.ReadLine();
                }
                else if (str != "end") { Console.WriteLine("Błędna komenda. Spróbuj ponownie"); }
            } while (str != "end");
            if (str == "end")
            { _orderRepository.Insert(NewOrder); }
        }
        public void ListAll()
        {
            foreach (Order zam in _orderRepository.GetAll())
            {
                Console.WriteLine(zam.ToString());
            }
        }
    }
}
