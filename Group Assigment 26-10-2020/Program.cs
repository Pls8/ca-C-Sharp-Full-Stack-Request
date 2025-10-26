using Group_Assigments.Models.project_1;
using Group_Assigments.Models.project_2;
using System.Collections.Generic;
using System.Net;
using System.Numerics;
using System.Xml.Linq;

namespace Group_Assigments
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //___________Project 1 — “Salalah Delivery Express”_____________________
            #region CD project 1
            //-----------------------------------------------------------
            //   ┌──────────────────────┐    ┌──────────────────┐        |
            //   │  DeliveryRequstClass │    │   DriverClass    │        |
            //   ├──────────────────────┤    ├──────────────────┤        |
            //   │ +orderNumber         │    │ +driverName      │        |
            //   │ +customerName        │    │ +Deliveries      │        |
            //   │ +driverName          │    │ List < Delivery >│        |
            //   │ +staus               │    ├──────────────────┤        |
            //   ├──────────────────────┤    │ +addDelivry()    │        |
            //   │ +DeliveryRequstClass │    │ +changeStaus()   │        |
            //   └──────────────────────┘    │ +showAllOrders() │        |
            //              ▲                └──────────────────┘        |
            //              │                         │                  |
            //              │ contains                │ contains         |
            //              └─────────────────────────┘                  |
            //                                                           |
            //   ┌─────────────────┐                                     |
            //   │   StatusEnums   │                                     |
            //   ├─────────────────┤                                     |
            //   │ Pending         │                                     |
            //   │ OntheWay        │                                     |
            //   │ Delviered       │                                     |
            //   └─────────────────┘                                     |
            //-----------------------------------------------------------
            #endregion

            Console.WriteLine("Project 1 — Salalah Delivery Express");
            DriverClass driver = new DriverClass("Nam1");
            driver.addDelivry(new DeliveryRequstClass("customer1", "Name1", 0001, Staus.pending));
            driver.showAllOrder();

            driver.changeOrderStaus(0001, Staus.onTheWay);
            driver.showAllOrder();

            //___________Project 1 — “Salalah Delivery Express”_____________________













            //___________Project 2 — “Salalah Book Café”  _____________________
            //                | > List<CafeClass> currentOrders (orders drinks)
            //customerClassP2 + 
            //                | > List<BookClass> bookClasses(borrows books)

            #region CD project 2
            //---------------------------------------------------------------------
            //   ┌─────────────┐        ┌─────────────┐        ┌─────────────┐     |
            //   │   Menu      │        │ Bookstatus  │        │  BookClass  │     |
            //   ├─────────────┤        ├─────────────┤        ├─────────────┤     |
            //   │  coffe      │        │ available   │        │ bookTitle   │     |
            //   │  tea        │        │ borrowed    │        │ bookstatus  │     |
            //   └─────────────┘        └─────────────┘        └─────────────┘     |
            //         │                         │                    │            |
            //         │                         │                    │            |
            //         ▼                         │                    │            |
            //   ┌─────────────┐                 │                    │            |
            //   │  CafeClass  │                 │                    │            |
            //   ├─────────────┤                 │                    │            |
            //   │   namE      │                 │                    │            |
            //   │   pricE     │                 │                    │            |
            //   │   menu      │                 │                    │            |
            //   └─────────────┘                 │                    │            |
            //         ▲                         │                    │            |
            //         │                         │                    │            |
            //         └─────────────────────────┼────────────────────┘            |
            //                                   │                                 |
            //         ┌─────────────────────────┼────────────────────┐            |
            //         │                         │                    │            |
            //         ▼                         ▼                    ▼            |
            //      ┌───────────────────────────────────────────────────────┐      |
            //      │                  customerClassP2                      │      |
            //      ├───────────────────────────────────────────────────────┤      |
            //      │  customerName                                         │      |
            //      │  currentOrders ──── List<CafeClass> ────┐             │      |
            //      │  bookClasses   ──── List<BookClass> ────┘             │      |
            //      └───────────────────────────────────────────────────────┘      |
            //---------------------------------------------------------------------
            #endregion

            Console.WriteLine("Project 2 — Salalah Book Cafe");
            //create book
            BookClass bk1 = new BookClass("book 1", Bookstatus.available);
            BookClass bk2 = new BookClass("book 2", Bookstatus.available);
            BookClass bk3 = new BookClass("book 3", Bookstatus.borrowed);

            //create menu
            CafeClass coffee = new CafeClass("Coffee", 1.5m, Menu.coffe);

            //customer
            customerClassP2 cm1 = new customerClassP2("customer 1");
            //add coffee
            cm1.addToOrder(coffee);
            //add book with 3 book to check condtion
            cm1.isBookBorrow(bk1);
            cm1.isBookBorrow(bk2);
            cm1.isBookBorrow(bk3);

            cm1.isBookBorrow(bk3);

            Console.WriteLine("Book Ststus");
            bk1.bookDisplay();
            bk2.bookDisplay();
            bk3.bookDisplay();

            //customer order
            Console.WriteLine($"{cm1.customerName} order [{cm1.currentOrders.Count}]");

            //___________Project 2 — “Salalah Book Café”  _____________________



        }
    }
}
