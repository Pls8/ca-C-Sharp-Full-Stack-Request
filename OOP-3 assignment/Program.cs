using oop_assigment_3.Q1;
using oop_assigment_3.Q2;
using System.Net.Sockets;

namespace oop_assigment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //_________________________________ Q1 _________________________________
            #region class diagram for the Ticket System
            // 
            //                           ┌─────────────────┐
            //                           │   TicketType    │  (Enum)
            //                           ├─────────────────┤
            //                           │ Regular         │
            //                           │ VIP             │
            //                           │ Backstage       │
            //                           └─────────────────┘
            //                                   △
            //                                   │ uses
            //                                   │
            //                           ┌─────────────────┐
            //                           │    Ticket       │  (Entity Class)
            //                           ├─────────────────┤
            //                           │ -EventName      │
            //                           │ -SeatNumber     │
            //                           │ -Type           │
            //                           ├─────────────────┤
            //                           │ +DisplayInfo()  │
            //                           └─────────────────┘
            //                                   △
            //                                   │ contains
            //                                   │
            //                           ┌─────────────────┐
            //                           │  TicketSystem   │  (Manager Class)
            //                           ├─────────────────┤
            //                           │ -tickets[]      │  < Array of Tickets
            //                           │ -ticketCount    │
            //                           ├─────────────────┤
            //                           │ +this[string]   │  < INDEXER 
            //                           │ +AddTicket()    │
            //                           │ +CountTicketsByType()│
            //                           └─────────────────┘
            #endregion

            Console.WriteLine("__________ Ticket System __________");
            TicketSystemClass systemClass = new TicketSystemClass();

            systemClass.addTicket("tk1", 3, TicketType.Regular);
            systemClass.addTicket("tk2", 4, TicketType.VIP);
            systemClass.addTicket("tk3", 7, TicketType.Backstage);

            systemClass.countTkType();

            // access ticket by seat number 
            TicketClass tk1 = systemClass[3];
            if (tk1 != null) {
                Console.Write("found > ");
                tk1.displayTicketInfo();
            }

            // diffrent way access using _public override string ToString()_
            systemClass.findSeat(7);

            //_________________________________ Q1 - E N D _________________________________








            //_________________________________ Q2 _________________________________
            #region class diagram online course
            //
            //                             ┌─────────────────┐
            //                             │     Level       │  (Enum)
            //                             ├─────────────────┤
            //                             │ Beginner        │
            //                             │ Intermediate    │
            //                             │ Advanced        │
            //                             └─────────────────┘
            //                                     △
            //                                     │ uses
            //                                     │
            //                             ┌─────────────────┐
            //                             │    Course       │  (Abstract Base)
            //                             ├─────────────────┤
            //                             │ +Name           │
            //                             │ +Instructor     │
            //                             │ +CourseLevel    │
            //                             ├─────────────────┤
            //                             │ +DisplayInfo()  │ < virtual
            //                             │ +GetCourseType()│ < abstract
            //                             └─────────────────┘
            //                                     △
            //                    ┌────────────────┼─────────────────┐
            //                    │                                  │
            //            ┌───────────────┐                   ┌───────────────┐
            //            │ VideoCourse   │                   │ LiveSession   │
            //            ├───────────────┤                   ├───────────────┤
            //            │ +DurationHours│                   │ +Schedule     │
            //            ├───────────────┤                   ├───────────────┤
            //            │ +DisplayInfo()│ < override        │ +DisplayInfo()│ < override
            //            └───────────────┘                   └───────────────┘
            //                    △                                   △
            //                    │                                   │
            //                    │                                   │
            //                    └───────────────────────────────────┘
            //                                   contains
            //                                      │
            //                             ┌─────────────────┐
            //                             │ CourseCatalog   │
            //                             ├─────────────────┤
            //                             │ -courses: List  │
            //                             ├─────────────────┤
            //                             │ +this[Level]    │ < INDEXER 
            //                             │ +AddCourse()    │
            //                             │ +DisplayByLevel()│
            //                             └─────────────────┘
            #endregion

            Console.WriteLine("------------------ online course --------------------");
            //create instnce/object
            CourseCatalogClass courseCatalog = new CourseCatalogClass();

            //adding course 
            courseCatalog.addCourseType("python", "Name1", Level.Beginner, 3.2);
            courseCatalog.addCourseType("java", "Name2", Level.Advanced, 2.2);

            courseCatalog.addCourseType("js", "Name3", Level.Intermediate, new DateTime(2025, 10, 27, 19, 0, 0));
            courseCatalog.addCourseType("php", "Name4", Level.Advanced, DateTime.Now.AddDays(3));

            //indexer by level <,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,
            Console.WriteLine();                                            //
            courseCatalog.displayCourseByLevel(Level.Advanced);             //
                                                                            //
            Console.WriteLine("diffrent way");// >,,,,,,,,,,,,,,,,,,,,,,,,,,//
            courseCatalog.getCourseByLevelDiffrentWay(Level.Advanced);

            //display course
            courseCatalog.displayAllCourse();
            //_________________________________ Q2 - E N D _________________________________


        }
    }
}
