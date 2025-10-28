using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assigment_3.Q4
{
    public class LibraryClass
    {
        List<BookClass> books;

        public LibraryClass()
        {
            books = new List<BookClass>();
        }

        
        //indexer
        public BookClass this[string title]  // <---------------------------------//
        {                                                                         //
            get {                                                                 //
                foreach (BookClass book in books) {                               //
                    return book;                                                  //
                }                                                                 //
                return null;                                                      //
            }                                                                     //
        }                                                                         //
                                                                                  //
                                                                                  //
        //add book                                                                //
        public void addBook(string title, string author, BookStatus status) {     //
            BookClass book = new BookClass(title, author, status);                //
            books.Add(book);                                                      //
        }                                                                         //
                                                                                  //
                                                                                  //
        //change book status                                                      //
        public void changeStatus(string title, BookStatus status) {               //
            BookClass book = this[title]; // indexer >--------------------------- //
            if (book != null) { book.BookStatus = status; }
        }

        //show book by  status
        public void showBookStatus(BookStatus status) { 
            bool found = false;
            foreach (BookClass book in books) {
                if (book.BookStatus == status) {
                    Console.WriteLine($"Title: {book.titlE} | Authoer: {book.authoR}");
                    found = true;
                }
            }
            if (!found) { Console.WriteLine($"Book with status [{status}] not found"); }
        }


        public void displayAllBooks()
        {
            foreach (BookClass book in books)
            {
                Console.WriteLine($"Title: {book.titlE} | Authoer: {book.authoR} | {book.BookStatus}");
            }
        }


    }
}
