using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Assigments.Models.project_1
{
    public abstract class DeliveryRequstClass
    {
        protected DeliveryRequstClass(string customerName, string driverName, Staus staus)
        {
            this.customerName = customerName;
            this.driverName = driverName;
            this.staus = staus;
        }

        public string customerName { get; set; }
        public string driverName { get; set; }
        public Staus staus { get; set; }



        public virtual void orderRequst(DeliveryRequstClass n) { }


        public virtual void displayInfo() {
            Console.WriteLine($"Order details {this.customerName}" +
                $"| {this.driverName} | {this.staus}");
        }

    }
}
