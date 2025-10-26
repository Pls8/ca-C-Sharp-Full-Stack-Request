using Group_Assigments.Models.project_1;
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
            //   ┌──────────────────────┐    ┌──────────────────┐
            //   │  DeliveryRequstClass │    │   DriverClass    │
            //   ├──────────────────────┤    ├──────────────────┤
            //   │ +orderNumber         │    │ +driverName      │
            //   │ +customerName        │    │ +Deliveries      │
            //   │ +driverName          │    │ List < Delivery >│
            //   │ +staus               │    ├──────────────────┤
            //   ├──────────────────────┤    │ +addDelivry()    │
            //   │ +DeliveryRequstClass │    │ +changeStaus()   │
            //   └──────────────────────┘    │ +showAllOrders() │
            //              ▲                └──────────────────┘
            //              │                         │
            //              │ contains                │ contains
            //              └─────────────────────────┘
            //
            //   ┌─────────────────┐
            //   │     Status      │
            //   ├─────────────────┤
            //   │ Pending         │
            //   │ InProgress      │
            //   │ Completed       │
            //   └─────────────────┘

            DriverClass driver = new DriverClass("Nam1");
            driver.addDelivry(new DeliveryRequstClass("customer1", "Name1", 0001, Staus.pending));
            driver.showAllOrder();

            driver.changeOrderStaus(0001, Staus.onTheWay);
            driver.showAllOrder();
            //___________Project 1 — “Salalah Delivery Express”_____________________






            




        }
    }
}
