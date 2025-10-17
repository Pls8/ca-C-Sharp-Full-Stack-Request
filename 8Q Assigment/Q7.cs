using ConsoleApp12_10_2025.Models;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace ConsoleApp12_10_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            #region 𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 7: 𝙇𝙞𝙗𝙧𝙖𝙧𝙮 𝘽𝙤𝙤𝙠 𝘽𝙤𝙧𝙧𝙤𝙬𝙞𝙣𝙜 𝙎𝙮𝙨𝙩𝙚𝙢
            //////////////////////////////////////////////////////////////////
            ////           𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 7: 𝙇𝙞𝙗𝙧𝙖𝙧𝙮 𝘽𝙤𝙤𝙠 𝘽𝙤𝙧𝙧𝙤𝙬𝙞𝙣𝙜 𝙎𝙮𝙨𝙩𝙚𝙢
            //_______________________________________________________________ S T A R T



            Console.WriteLine("-------------- Library Book borrwing ------------------");

            string[] books = [ "book1",   "book2",   "book3",   "book4"];
            string[] isBookBorrowed = new string[books.Length];

            // mark all books Yes(available) at first
            for (int i = 0; i < books.Length; i++)
            {
                isBookBorrowed[i] = "Yes";
            }

            int choiceBookLib = 0;
            do {

                Console.WriteLine("\n\t____________Menu____________");
                Console.WriteLine("1.view books | 2.borrow book | 3.return book | 4.check book available | 5.exit");
                choiceBookLib = int.Parse(Console.ReadLine());

                switch (choiceBookLib)
                {
                    case 1: //view
                        displayBook(books, isBookBorrowed);
                        break;

                    case 2: //borrow
                        displayBook(books, isBookBorrowed);
                        Console.Write("\nEnter Book Number to borrow: ");
                        int bookNumBorrow = int.Parse(Console.ReadLine());
                        if (bookNumBorrow < 1 || bookNumBorrow > books.Length)
                        {
                            Console.WriteLine("Invalid book number!");
                            return;
                        }

                        int indexBook = bookNumBorrow - 1; // store index in temp value
                        if (isBookBorrowed[indexBook] != "Yes")
                        {
                            Console.WriteLine($"Book: [{books[indexBook]}], already borrwed" +
                                $" | Available: [{isBookBorrowed[indexBook]}]");
                        }
                        else
                        {                            
                            isBookBorrowed[indexBook] = "No";
                            Console.WriteLine($"You have borrowed book: [{books[indexBook]}]");
                        }                        
                            break;

                    case 3: //return
                        int bookBrrowCounter = 0;
                        for (int i = 0; i < books.Length; i++) {
                            if (isBookBorrowed[i] == "No") //Show only No book mark
                            {
                                Console.WriteLine($"{i + 1} | {books[i]} | {isBookBorrowed[i]}");
                                bookBrrowCounter++;
                            }
                        }
                        if (bookBrrowCounter == 0)
                        {
                            Console.WriteLine("No book borrowed");
                            return ;
                        }

                        Console.WriteLine("Enter borrowed book number to return: ");
                        bookNumBorrow = int.Parse (Console.ReadLine());
                        if (bookNumBorrow < 1 || bookNumBorrow > books.Length)
                        {
                            Console.WriteLine("Invalid book number!");
                            return;
                        }

                        indexBook = bookNumBorrow - 1;
                        if (isBookBorrowed[indexBook] == "Yes")
                        {
                            Console.WriteLine($"{books[indexBook]} not a borrwoed book!");
                        }
                        else
                        {
                            isBookBorrowed[indexBook] = "Yes";
                            Console.WriteLine($"Book [{books[indexBook]}] was returning");
                        }

                        break;


                    case 4:  // check book availability
                        for (int i = 0; i < books.Length; i++) {
                            if (isBookBorrowed[i] != "No")
                            {
                                Console.WriteLine($"{isBookBorrowed[i]} | {books[i]}");
                            }
                        }

                        //serach by name of book?
                        Console.WriteLine("Enter Book name: ");
                        string bookNameAvl = Console.ReadLine().ToLower();
                        int indexSerachBook = -1; // -1 cuz we don't need to start from index 0
                        for (int i = 0; i < books.Length; i++) {
                            if (books[i].Contains(bookNameAvl))
                            {
                                indexSerachBook = i;
                                break;
                            }
                        }

                        if (indexSerachBook != -1)
                        {
                            if (isBookBorrowed[indexSerachBook] == "Yes")
                            {
                                Console.WriteLine($"[{books[indexSerachBook]}] is available");
                            }
                            else
                            {
                                Console.WriteLine($"{books[indexSerachBook]} is currently borroed!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Book not found in lib");
                        }
                        break;
                    default:
                        break;
                }

            } while (choiceBookLib != 5);

            static void displayBook(string[] bk, string[] isBr) {
                Console.WriteLine("\nNO. \tAvailable \tBooks");
                Console.WriteLine("----------------------------");
                int yesCount = 0, noCount = 0; //indicate if there book or not
                for (int i = 0; i < bk.Length; i++) {
                    string statusBorrow = isBr[i] == "Yes" ? "Yes" : "No";     //Ternary Operator: (condition) ? valueIfTrue : valueIfFalse;
                    Console.WriteLine($"{i + 1} \t|{statusBorrow}  \t\t|{bk[i]}");

                    if (isBr[i] == "Yes"){ yesCount++; }
                    else { noCount++; }
                }
                Console.WriteLine($"Available books: {yesCount} | Borrwed books: {noCount}");
            }



            //------------------------------------------------------------------------------------------------- E N D
            //                       𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 7: 𝙇𝙞𝙗𝙧𝙖𝙧𝙮 𝘽𝙤𝙤𝙠 𝘽𝙤𝙧𝙧𝙤𝙬𝙞𝙣𝙜 𝙎𝙮𝙨𝙩𝙚𝙢 
            ///////////////////////////////////////////////////////////////////////////////////////////////////
            #endregion








        }
    }

}
