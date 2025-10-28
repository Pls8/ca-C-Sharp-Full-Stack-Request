using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assigment_3.Q4
{
    public class BookClass
    {
        public BookClass(string titlE, string authoR, BookStatus bookStatus)
        {
            this.titlE = titlE;
            this.authoR = authoR;
            BookStatus = bookStatus;
        }

        public string titlE { get; set; }
        public string authoR { get; set; }
        public BookStatus BookStatus { get; set; }




    }
}
