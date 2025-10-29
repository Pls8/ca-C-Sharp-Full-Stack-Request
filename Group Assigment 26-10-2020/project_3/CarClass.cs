using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Assigments.project_3
{
    public class CarClass
    {
        public CarClass(string licensePlate, string model, decimal dailyRate)
        {
            this.licensePlate = licensePlate;
            this.model = model;
            this.dailyRate = dailyRate;
            CarStatus = CarStatus.available;
        }

        public string licensePlate  { get; set; }
        public string model { get; set; }
        public decimal dailyRate { get; set; }
        public CarStatus CarStatus  { get; set; }


    }
}
