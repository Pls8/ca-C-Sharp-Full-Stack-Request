using oop_assigment_3.Q1;
using oop_assigment_3.Q2;
using oop_assigment_3.Q3;
using oop_assigment_3.Q4;
using oop_assigment_3.Q5;
using System.Diagnostics.Metrics;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace oop_assigment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //_________________________________ Q1 __________________________________
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
            systemClass.findSeat(7);                                 Console.WriteLine();
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

            Console.WriteLine("\n\n------------------ online course --------------------");
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
            courseCatalog.displayAllCourse();                           Console.WriteLine();
            //_________________________________ Q2 - E N D _________________________________











            //_________________________________ Q3 _________________________________
            //credit github.com/Fayadh-Alhabshi
            #region class diagram  Smart Home Control Center
            //
            //                         ┌─────────────────┐
            //                         │   DeviceType    │  (Enum)
            //                         ├─────────────────┤
            //                         │ Light           │
            //                         │ Fan             │
            //                         │ AC              │
            //                         │ Heater          │
            //                         └─────────────────┘
            //                                 △
            //                                 │ uses
            //                                 │
            //                         ┌─────────────────┐
            //                         │ ISmaretDevice-  │ 
            //                         │ Interface       │
            //                         ├─────────────────┤
            //                         │ +DeviceType     │ 
            //                         │ +turnOn()       │ 
            //                         │ +turnOff()      │ 
            //                         │ +showStatus()   │ 
            //                         └─────────────────┘
            //                                 △
            //                ┌────────────────┼─────────────────┐
            //        ┌───────┼───────┐  ┌─────┼─────┐  ┌────────┼────────┐
            //        │   FanClass    │  │  ACClass  │  │   HeaterClass  │
            //        ├───────────────┤  ├───────────┤  ├────────────────┤
            //        │ -isOn         │  │ -isOn     │  │ -isOn          │
            //        │               │  │ -temp     │  │ -temp          │
            //        ├───────────────┤  ├───────────┤  ├────────────────┤
            //        │ +turnOn()     │  │ +turnOn() │  │ +turnOn()      │
            //        │ +turnOff()    │  │ +turnOff()│  │ +turnOff()     │
            //        │ +showStatus() │  │ +showStatus│  │ +showStatus() │
            //        └───────────────┘  └───────────┘  └────────────────┘
            //                △                                 △
            //                │                                 │
            //                └─────────────────────────────────┘
            //                                         │
            //                                         │ contains
            //                                         │
            //                         ┌─────────────────┐
            //                         │ SmartHomeClass  │  
            //                         ├─────────────────┤
            //                         │ -Devices: List  │ 
            //                         │ +DeviceType     │ 
            //                         ├─────────────────┤
            //                         │ +turnOn()       │
            //                         │ +turnOff()      │ 
            //                         │ +showStatus()   │
            //                         │ +this[DeviceType]│
            //                         └─────────────────┘

            #endregion
            Console.WriteLine("\n\n____________ Smart Home Control Center _________________");
            List<ISmaretDeviceInterface> devices = new List<ISmaretDeviceInterface>();
            devices.Add(new FanClass());
            devices.Add(new ACClass());
            devices.Add(new HeaterClass());
            devices.Add(new LightClass());

            SmartHomeClass smartHome = new SmartHomeClass(devices);
            smartHome.showStatus();
            smartHome.turnOn();
            smartHome.showStatus();

            ISmaretDeviceInterface tempDev = smartHome[DeviceType.light];
            if (tempDev != null)
            {
                Console.WriteLine($"device type [{tempDev.DeviceType}] ");
                tempDev.turnOn();
                tempDev.showStatus();
            }
            else { Console.WriteLine("No device Type"); }            
            //_________________________________ Q3 - E N D _________________________________









            //_________________________________ Q4 _________________________________
            #region class diagram LIBRARY SYSTEM
            //
            //                ┌─────────────────┐
            //                │   BookStatus    │  (Enum)
            //                ├─────────────────┤
            //                │ Available       │
            //                │ CheckedOut      │
            //                │ Reserved        │
            //                └─────────────────┘
            //                        △
            //                        │ uses
            //                        │
            //                ┌─────────────────┐
            //                │      Book       │
            //                ├─────────────────┤
            //                │ +Title          │
            //                │ +Author         │
            //                │ +Status         │
            //                └─────────────────┘
            //                        △
            //                        │ contains
            //                        │
            //                ┌─────────────────┐
            //                │     Library     │
            //                ├─────────────────┤
            //                │ -books: List    │
            //                ├─────────────────┤
            //                │ +this[string]   │ ← INDEXER
            //                │ +AddBook()      │
            //                │ +ChangeStatus() │
            //                │ +ShowBooksByStatus()│
            //                └─────────────────┘
            #endregion

            Console.WriteLine("\n\n________ Library System with Book Status Tracking _____________");
            LibraryClass library = new LibraryClass();
            library.addBook("Book 1", "Name 1", BookStatus.available);
            library.addBook("Book 2", "Name 2", BookStatus.checkout);
            library.addBook("Book 3", "Name 3", BookStatus.reserved);

            Console.WriteLine("--- Added Books ---");
            library.displayAllBooks();

            Console.WriteLine("____ Book Indexer by Title ____");
            BookClass bk1 = library["Book 1"];
            if (bk1 != null) {
                Console.WriteLine($"Book [{bk1.titlE}], [{bk1.authoR}], [{bk1.BookStatus}]");
            }

            Console.WriteLine("____ Book by Status ____");
            library.showBookStatus(BookStatus.checkout);

            Console.WriteLine("____ Change Book status ____");
            library.changeStatus("Book 3", BookStatus.available);
            library.showBookStatus(BookStatus.available);
            //_________________________________ Q4 E N D _________________________________










            //_________________________________ Q5 _________________________________
            #region class diagram Task Tracker Application
            //
            //                     ┌─────────────────┐
            //                     │  TaskPriority   │  (Enum)
            //                     ├─────────────────┤
            //                     │ Low             │
            //                     │ Medium          │
            //                     │ High            │
            //                     └─────────────────┘
            //                             △
            //                             │ uses
            //                             │
            //                     ┌─────────────────┐
            //                     │      Task       │
            //                     ├─────────────────┤
            //                     │ +Title          │
            //                     │ +Description    │
            //                     │ +Priority       │
            //                     │ +IsCompleted    │
            //                     └─────────────────┘
            //                             △
            //                             │ contains
            //                             │
            //                     ┌─────────────────┐
            //                     │    TaskList     │
            //                     ├─────────────────┤
            //                     │ -tasks: List    │
            //                     ├─────────────────┤
            //                     │ +this[TaskPriority]│ ← INDEXER
            //                     │ +AddTask()      │
            //                     │ +MarkComplete() │
            //                     │ +ShowAll()      │
            //                     └─────────────────┘
            #endregion

            Console.WriteLine("\n\n_____________ Task Tracker Application _________________");
            TaskListClass taskList = new TaskListClass();

            //adding task
            taskList.addTask(new TaskClass("do something", "nothing change", TaskPriority.low));
            taskList.addTask(new TaskClass("something?", "nothing change", TaskPriority.medium));
            taskList.addTask(new TaskClass("is something!", "nothing change", TaskPriority.high));
            taskList.addTask(new TaskClass("something is?", "nothing change", TaskPriority.high));

            taskList.showAllTask();

            Console.WriteLine("___Mark Task Comp__");
            taskList.markComplete("do something"); // use index?
            taskList.showAllTask();

            Console.WriteLine("___ Task Proirity ___");
            List<TaskClass> taskPriority = taskList[TaskPriority.high];
            foreach (TaskClass tsk in taskPriority) {
                string status = tsk.isCompleted ? "complete" : "pending";
                Console.WriteLine($"title: [{tsk.title}] | status [{status}] | [{tsk.priority}]");
            }
            //_________________________________ Q5 E N D _________________________________





        }
    }
}
