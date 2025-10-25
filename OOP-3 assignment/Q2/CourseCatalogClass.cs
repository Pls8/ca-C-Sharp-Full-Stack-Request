using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assigment_3.Q2
{
    public class CourseCatalogClass
    {
        // object,field initialization > two way of doing this 
        List<CourseClass> courses = new List<CourseClass>(); // 1
                                  //  ^----------------------------------------|
                                  //constructer, container class?                                         |
                                  //public CourseCatalogClass() { courses = new List<CourseClass>(); } -->| 2
                                  // inside a counstrcuter!



        //add course                                
        public void addCourse(CourseClass course) { // <<------------------------------------------//|
            courses.Add(course);                                                                   //|
            Console.WriteLine($"added: [{course.courseName}] [{course.getCourseType()}]");         //|
        }                                                                                          //|
                                                                                                   //|
        //add video course                         method delegation > addCourse();                //|
        public void addCourseType(string n, string inst, Level lvl, double dur) {                 //|
            VideoCourseClass cours = new VideoCourseClass(n, inst, lvl, dur);                      //|
            addCourse(cours); // >>----------------------------------------------------------------//
        }                                                                                          //|
        // overloading video to live session        method delegation > addCourse();               //|
        public void addCourseType(string n, string inst, Level lvl, DateTime dt)                   //|
        {                                                                                          //|
            LiveSessionClass cours = new LiveSessionClass(n, inst, lvl, dt);                       //|
            addCourse(cours); // >>---------------------------------------------------------------//
        }




        //________________________Note______________________________________
        //  displayCourseByLevel(Level)                                     |
        //          │                                                       |
        //          ▼                                                       |
        //    this[level]  ←── calls ───  indexer get {...}                 |
        //          │                                                       |
        //          ▼                                                       |
        //    returns List<CourseClass>                                     |
        //          │                                                       |
        //          ▼                                                       |
        //    display each course                                           |
        //                                                                  |
        ////indexer by level                                                |
        //The indexer is like a “getter” for courses by level.              |
        //The display method uses that getter to show the result.           |
        public List<CourseClass> this[Level level] // <---------------------//
        {                                                                   //
            get                                                             //
            {                                                               //
                List<CourseClass> reslt = new List<CourseClass>();          //
                foreach (CourseClass c in courses)                          //
                {                                                           //
                    if (c.leveL == level)                                   //
                    {                                                       //
                        reslt.Add(c);                                       //
                    }                                                       //
                                                                            //
                }                                                           //
                return reslt;                                               //
            }                                                               //
        }                                                                   //
                                                                            //
        //display level by using indexer                                    //
        public void displayCourseByLevel(Level level) {                     //
            // v--- call indexer >------------------------v                 //
            List<CourseClass> lvlCourse = this[level]; // |>----------------//
                                                                            //
            Console.WriteLine("..... level course .........");              //
            if (lvlCourse.Count == 0)                                       //
            {                                                               //
                Console.WriteLine("No course yet");                         //
            }                                                               //
            else                                                            //
            {                                                               //
                foreach (CourseClass course in lvlCourse) {                 //
                    course.displayInfoCourse();                             //
                    Console.WriteLine("------------");                      //
                }                                                           //
            }                                                               //
        }                                                                   //______________
        //**another way get course by level instied of using THIS[] keyword!>^             //
        public List<CourseClass> getCourseByLevelDiffrentWay(Level lvl) {                  //
            // create empty list match course level ---v                                   //
            List<CourseClass> resL = new List<CourseClass>();                              //
            foreach (CourseClass course in courses)                                        //
            {                                                                              //
                if (course.leveL == lvl)                                                   //
                {                                                                          //
                   resL.Add(course);                                                       //
                   Console.WriteLine($"level [{course.leveL}] | [{course.courseName}]");   //
                }                                                                          //
            }                                                                              //
            Console.WriteLine($"found _{resL.Count}_");                                    //
            return resL;                                                                   //
        }                                                                                  //
        //--------------------------------------------------------------------------------//



        // display all
        public void displayAllCourse() {
            Console.WriteLine("~~~~~~~ all course ~~~~~~~");
            if (courses.Count == 0)
            {
                Console.WriteLine("no course yet");
            }
            else {
                foreach (CourseClass course in courses) {
                    course.displayInfoCourse();
                    Console.WriteLine("-----");
                }
            }
        }




    }
}
