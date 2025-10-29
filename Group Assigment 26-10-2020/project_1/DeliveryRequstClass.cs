using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Assigments.project_1
{
    public class DeliveryRequstClass
    {
        public string customerName { get; set; }
        public int orderNumber { get; set; }
        public string driverName { get; set; }
        public Staus staus { get; set; }

        public DeliveryRequstClass(string customerName, string driverName, int orderNumber, Staus staus)
        {
            this.customerName = customerName;
            this.driverName = driverName;
            this.orderNumber = orderNumber;
            this.staus = staus;
        }

        



        //public virtual void orderRequst(DeliveryRequstClass n) { }

        public void changeDevStaus(Staus s) { 
            staus = s;
            Console.WriteLine($"{customerName} {staus}");
        }

        public void displayInfo() {
            Console.WriteLine($"Order details {customerName}" +
                $"| {driverName} | {staus}");
        }

    }
}
