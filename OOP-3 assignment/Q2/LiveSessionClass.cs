using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assigment_3.Q2
{
    public class LiveSessionClass : CourseClass
    {
        public LiveSessionClass(string courseName, string instructorName, Level leveL, DateTime schedule)
            : base(courseName, instructorName, leveL)
        {
            scheduaL = schedule;    
        }

        public DateTime scheduaL { get; set; }



        public override void displayInfoCourse()
        {
            base.displayInfoCourse();
            Console.WriteLine("........ live session ......");
            Console.WriteLine($"schedule [{scheduaL:yyyy-M-dd h:m}]");
        }


        public override string getCourseType()
        {
            return "Live session";
        }


        //// is seem that schedual can be chagne to current time?
        //public bool isUpcoming()
        //{
        //    return scheduaL > DateTime.Now;
        //}
    }
}
