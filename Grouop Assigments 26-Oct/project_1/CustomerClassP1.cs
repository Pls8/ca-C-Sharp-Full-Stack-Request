using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Assigments.project_1
{
    public class CustomerClassP1 // : DeliveryRequstClass
    {
        public CustomerClassP1(string namE)
        {
            custmerName = namE;
        }

        public string custmerName { get; set; }



        //List<DeliveryRequstClass> deliveryRequstClasses;

        //public string isDelevered { get; set; }
        //public CustomerClassP1(string customerName, string driverName, Staus staus, string delver)
        //    : base(customerName, driverName, staus)
        //{
        //    this.isDelevered = delver;
        //}

        //public override void orderRequst(DeliveryRequstClass n)
        //{
        //    deliveryRequstClasses = new List<DeliveryRequstClass>();
        //    deliveryRequstClasses.Add(n);
        //}

        //public override void displayInfo()
        //{
        //    base.displayInfo();
        //    return;
        //}



    }
}
