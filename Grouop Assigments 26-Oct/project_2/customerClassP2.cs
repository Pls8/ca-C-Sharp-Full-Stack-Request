using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Assigments.project_2
{
    public class customerClassP2
    {
        public customerClassP2(string customerName)
        {
            this.customerName = customerName;
            currentOrders = new List<CafeClass>();
            bookClasses = new List<BookClass>();
        }

        public string customerName { get; set; }
        public List<CafeClass> currentOrders { get; set; }
        public List<BookClass> bookClasses { get; set; }




        public void addToOrder(CafeClass order) { 
            currentOrders.Add(order);
            Console.WriteLine($"{customerName} ordered {order.namE}");
        }




        public void isBookBorrow(BookClass books) {
            if (bookClasses.Count >= 2)
            {
                Console.WriteLine($"{customerName} caanot bborrow more than 2!");
            }
            else if (books.bookstatus == Bookstatus.available)
            {
                bookClasses.Add(books);
                Console.WriteLine($"{customerName} borrowed {books.bookTitle}");
            }
            else {
                Console.WriteLine($"{books.bookTitle} already borrowed!");
            }
        }





        //rest?
        public void returnAllBookStatus()
        {
            foreach (BookClass book in bookClasses)
            {
                book.bookstatus = Bookstatus.available;
                Console.WriteLine("All book status rest");
            }
        }




    }
}
