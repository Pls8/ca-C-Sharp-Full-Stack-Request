using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Assignment 3: Vehicle Hierarchy System 

namespace ConsoleApp12_10_2025.Models
{
    public class CarClass : VehicleClass // class drived
    {
        public CarClass(string make, string model, int year, int numOfDoor)
            : base(make, model, year) // use : base(VehiclClas parameter)
        {
            this.numOfDoor = numOfDoor;
        }

        public int numOfDoor { get; set; }

        // make  DisplayInfo() in VehicleClass virtual then add override
        public override string DisplayInfo()
        { 
            return $"Car: {YearCar}, {makeCar}, {modelCar}   | Doors: {numOfDoor}";
        }


        public void numberOfDoor()
        {
            Console.WriteLine("Number of Door");
        }
    }
}
