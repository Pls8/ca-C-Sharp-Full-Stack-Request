using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

//Assignment 1: Book Class System 

namespace ConsoleApp12_10_2025.Models
{
    public class BookClass  //2 [ ctrl + . ] >  Generate constructors from member >>_
    {   //                                                                           |
        //                                                                           |        
        //2 v------------------------------------------------------------------------/
        //  v    constructors should use _this._
        public BookClass(int iSBN, string titleBook, string authorBook, int year)
        {
            ISBN = iSBN;
            this.titleBook = titleBook;
            this.authorBook = authorBook;
            this.bookYear = year;
        }

        public const int BOOKYEAR = 1990;

        //1 create memeber
        public int ISBN { get; }
        public string titleBook { get; set; }
        public string authorBook { get; set; }
        public int bookYear { get; set; }



        //this is diffrent way
        public string PrintBookInfo()
        {
            return $"ISBN: {this.ISBN} | Title: {this.titleBook} | Author: {this.authorBook} | Year: {this.bookYear}";
        }



        public bool isBookOlder()
        {
            //return bookYear < BOOKYEAR;
            return this.bookYear < BOOKYEAR;
        }


    }
}
