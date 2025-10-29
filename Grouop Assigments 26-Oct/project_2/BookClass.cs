using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Assigments.project_2
{
    public class BookClass
    {
        public BookClass(string bookTitle, Bookstatus bookstatus)
        {
            this.bookTitle = bookTitle;
            this.bookstatus = bookstatus;
        }

        public string bookTitle { get; set; }
        public Bookstatus bookstatus { get; set; }


        public void bookDisplay() {
            string isAvlblBarrow = bookstatus == Bookstatus.available ? "avalibel": "borrowed";
            Console.WriteLine($"{bookTitle} | {isAvlblBarrow}");
        }




    }
}
