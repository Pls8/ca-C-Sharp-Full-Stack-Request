using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Assigments.project_3
{
    public class RentalRecordClass
    {
        public RentalRecordClass(int duration, CustomerClass customerClass, CarClass carClass)
        {
            this.duration = duration;
            this.totalCost =  carClass.dailyRate * duration;
            CustomerClass = customerClass;
            this.carClass = carClass;
        }

        public int duration { get; set; }
        public decimal totalCost { get; set; }
        public CustomerClass CustomerClass { get; set; }
        public CarClass carClass { get; set; }
    }
}
