using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Assignment 3: Vehicle Hierarchy System 

namespace ConsoleApp12_10_2025.Models
{
    public class TruckClass : VehicleClass
    {
        public TruckClass(string make, string model, int year, double LoadCapacity)
            : base(make, model, year) // use : base(VehiclClas parameter)
        {
            this.LoadCapacity = LoadCapacity;
        }

        public double LoadCapacity { get; set; }

        public void Load() {
            Console.WriteLine("Load Capacity");
        }
        //public override string DisplayInfo()
        //{
        //    return $"Truck: {YearCar}, {makeCar}, {modelCar}   | Load Capacity: {LoadCapacity}";
        //}
    }
}
