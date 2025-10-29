using Group_Assigments.project_1;
using Group_Assigments.project_2;
using Group_Assigments.project_3;
using Group_Assigments.project_4;
using System.Collections.Generic;
using System.Net;
using System.Numerics;
using System.Runtime.InteropServices;
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

            //___________Project 1 — “Salalah Delivery Express” E N D _____________________













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

            Console.WriteLine("\nProject 2 — Salalah Book Cafe");
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
            //___________Project 2 — “Salalah Book Café” E N D   _____________________








            //___________Project 3 — “Dhofar Car Rental”  _____________________
            #region CD Dhofar car rental
            //
            //                             ┌─────────────────┐
            //                             │   CarStatus     │  (Enum)
            //                             ├─────────────────┤
            //                             │ Available       │
            //                             │ Rented          │
            //                             └─────────────────┘
            //                                     △
            //                    ┌────────────────┼─────────────────┐
            //                    │                                  │
            //            ┌───────────────┐                  ┌───────────────┐
            //            │     Car       │                  │   Customer    │
            //            ├───────────────┤                  ├───────────────┤
            //            │ +LicensePlate │                  │ +Name         │
            //            │ +Model        │                  │ +Phone        │
            //            │ +DailyRate    │                  └───────────────┘
            //            │ +Status       │                          △
            //            └───────────────┘                          │
            //                    △                                  │
            //                    │                                  │
            //                    └──────────────────────────────────┘
            //                                      used in
            //                                      │
            //                             ┌───────────────┐
            //                             │ RentalRecord  │
            //                             ├───────────────┤
            //                             │ +Customer     │
            //                             │ +Car          │
            //                             │ +DurationDays │
            //                             │ +TotalCost    │
            //                             └───────────────┘
            //                                      △
            //                                      │ managed by
            //                                      │
            //                             ┌───────────────┐
            //                             │ RentalSystem  │
            //                             ├───────────────┤
            //                             │ -cars: List   │
            //                             │ -customers:   │
            //                             │ -rentalRecords│
            //                             ├───────────────┤
            //                             │ +this[CarStatus]│ ← INDEXER
            //                             │ +AddCar()     │
            //                             │ +AddCustomer()│
            //                             │ +RentCar()    │
            //                             │ +ReturnCar()  │
            //                             │ +ShowAvailableCars()│
            //                             │ +CalculateTotalRevenue()│
            //                             └───────────────┘
            #endregion

            Console.WriteLine("\nDhofar Car Rental");
            RentalSystemClass rentalSystemClass = new RentalSystemClass();

            //add car
            rentalSystemClass.AddCar("abc123", "Car 1", 29m);
            rentalSystemClass.AddCar("abc456", "Car 2", 9m);
            rentalSystemClass.AddCar("abc789", "Car 3", 19m);

            //add customer
            rentalSystemClass.AddCustomer("Name 1","9999");
            rentalSystemClass.AddCustomer("Name 2", "8888");

            rentalSystemClass.showAvailableCars();

            Console.WriteLine("---- indexer by car satus ----");
            foreach (CarStatus status in Enum.GetValues<CarStatus>())
            {
                List<CarClass> cars = rentalSystemClass[status]; //indexer
                Console.WriteLine($"[{status}] | car: {cars.Count}");

                foreach (CarClass car in cars) {
                    Console.WriteLine($"{car.licensePlate} | {car.model} | {car.dailyRate}.OMR/day");
                }
            }

            //rent car
            rentalSystemClass.rentCar("Name 1", "abc123", 2);
            rentalSystemClass.rentCar("Name 2", "abc456", 7);
            Console.WriteLine("Avaiable car after rent");
            rentalSystemClass.showAvailableCars();

            Console.WriteLine($".....Revenus....: {rentalSystemClass.calcluateTotalRev()}");

            //return car
            Console.WriteLine("Return a Car");
            rentalSystemClass.returnCar("abc123");
            Console.WriteLine("Avaiable car after return");
            rentalSystemClass.showAvailableCars();                         //note: something missing!!!
            //___________Project 3 — “Dhofar Car Rental” E N D  _____________________








            //___________ Project 4 — “Salalah Sports League”   _____________________
            #region CD Salaah sport League
            //
            //                ┌───────────────┐
            //                │     Team      │
            //                ├───────────────┤
            //                │ +Name         │
            //                │ +Coach        │
            //                │ +Players: List│
            //                └───────────────┘
            //                        △
            //                        │ participates in
            //                        │
            //                ┌───────────────┐
            //                │    Match      │
            //                ├───────────────┤
            //                │ +Team1        │
            //                │ +Team2        │
            //                │ +Score1       │
            //                │ +Score2       │
            //                │ +Winner       │
            //                └───────────────┘
            //                        △
            //                        │ managed by
            //                        │
            //             ┌───────────────────┐
            //             │    League         │
            //             ├───────────────────┤
            //             │ -teams: List      │
            //             │ -matches: List    │
            //             ├───────────────────┤
            //             │ +this[string]     │ ← INDEXER
            //             │ +AddTeam()        │
            //             │ +AddPlayer()      │
            //             │ +RecordMatch()    │
            //             │ +ShowStandings()  │
            //             │ +ShowAllMatches() │
            //             │ +ShowTeamDetails()│
            //             └───────────────────┘
            #endregion
            Console.WriteLine("\n ------------ Salalah Sports League -----------");

            LeagueClass league = new LeagueClass();

            //add team & player------------------------------//
            league.addTeam("Team 1", "Coach 1");             //
                league.addPlayers("Team 1", "player 1");     //
                league.addPlayers("Team 1", "player 2");     //
                                                             //
            league.addTeam("Team 2", "Coach 2");             //
                league.addPlayers("Team 2", "player 1");     //
                league.addPlayers("Team 2", "player 2");     //
                                                             //
            league.addTeam("Team 3", "Coach 3");             //
                league.addPlayers("Team 3", "player 1");     //
                league.addPlayers("Team 3", "player 2");     //
                                                             //
            league.addTeam("Team 4", "Coach 4");             //
                league.addPlayers("Team 4", "player 1");     //
                league.addPlayers("Team 4", "player 2");     //


            //indexer by team name
            Console.WriteLine("Indexer Team Name");
            TeamClass team1 = league["Team 2"];
            if (team1 != null) {
                Console.WriteLine($"{team1.namE} | {team1.coacH}");
            }


            //record match
            league.recordMatch("Team 1", "Team 2", 3, 1);
            league.recordMatch("Team 3", "Team 4", 2, 4);

            //show matches result
            Console.WriteLine("Result");
            league.showResult();

            // team deatils
            Console.WriteLine("Team Details by Name");
            league.displayTeamDetails("Team 1");
            //___________ Project 4 — “Salalah Sports League”  E N D  _____________________
        }
    }
}
