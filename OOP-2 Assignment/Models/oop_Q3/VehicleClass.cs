using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Assignment 3: Vehicle Hierarchy System 

namespace ConsoleApp12_10_2025.Models
{
    public class VehicleClass
    {
        public VehicleClass(string makeCar, string modelCar, int yearCar)
        {
            this.makeCar = makeCar;
            this.modelCar = modelCar;
            YearCar = yearCar;
        }

        public string makeCar { get; set; }
        public string modelCar { get; set; }
        public int YearCar { get; set; }

        //virtual for overriding, is it realy important to make virtual?
        public virtual string DisplayInfo() {
            return $"Vehicle: {this.makeCar} | {this.modelCar} | {this.YearCar}";
        }


    }
}
