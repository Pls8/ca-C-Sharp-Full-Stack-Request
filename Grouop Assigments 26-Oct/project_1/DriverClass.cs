using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Assigments.project_1
{
    public class DriverClass // : DeliveryRequstClass
    {

        public string driverName { get; set; }
        public List<DeliveryRequstClass> Deliveries { get; set; }

        public DriverClass(string driverName)
        {
            this.driverName = driverName;
            Deliveries = new List<DeliveryRequstClass>();
        }



        public void addDelivry(DeliveryRequstClass req)
        {
            Deliveries.Add(req);
        }


        public void changeOrderStaus(int orderNum, Staus newSt)
        {
            foreach (var delviry in Deliveries)
            {
                if (delviry.orderNumber == orderNum)
                {
                    delviry.staus = newSt;
                    Console.WriteLine($"Order: {delviry.orderNumber} | status change to {newSt}");
                }
            }
        }

        public void showAllOrder() {
            Console.WriteLine($"driver: [{driverName}] order: ");
            foreach (var delviry in Deliveries)
            {
                Console.WriteLine($"order number: {delviry.orderNumber} | " +
                    $"name: [{delviry.customerName}] | [{delviry.staus}]");
            }
        }










    }
}
