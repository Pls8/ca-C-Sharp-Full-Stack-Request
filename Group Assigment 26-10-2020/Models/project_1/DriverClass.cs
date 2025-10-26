using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Assigments.Models.project_1
{
    public class DriverClass : DeliveryRequstClass
    {
        //public string driverName { get; set; }
        public int shipNumber { get; set; }
        //public string custmerName { get; set; }
        public DriverClass(string customerName, string driverName, Staus staus, int shipNum)
            : base(customerName, driverName, staus)
        {
            this.shipNumber = shipNum;
        }
    }
}
