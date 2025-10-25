using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assigment_3.Q2
{
    public class VideoCourseClass : CourseClass
    {
        public VideoCourseClass(string courseName, string instructorName, Level leveL, double duration)
            : base(courseName, instructorName, leveL)
        {
            durationHours = duration;
        }

        public double durationHours { get; set; }



        public override void displayInfoCourse()
        {
            base.displayInfoCourse();
            Console.WriteLine("......... Video course ........");
            Console.WriteLine($"duration [{durationHours}]");
        }


        public override string getCourseType()
        {
            return "video course";
        }
    }
}
