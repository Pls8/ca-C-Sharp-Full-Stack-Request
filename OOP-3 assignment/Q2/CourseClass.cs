using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assigment_3.Q2
{
    public abstract class CourseClass
    {
        protected CourseClass(string courseName, string instructorName, Level leveL)
        {
            this.courseName = courseName;
            this.instructorName = instructorName;
            this.leveL = leveL;
        }

        public string courseName { get; set; }
        public string instructorName { get; set; }
        public Level leveL { get; set; }



        public virtual void displayInfoCourse() {
            Console.WriteLine($"course: [{courseName}] | instructer [{instructorName}] | level [{leveL}]");
        }

        //abstract: each subclass must implement this method
        public abstract string getCourseType(); // this is for distinguish video OR live session
    }
}
