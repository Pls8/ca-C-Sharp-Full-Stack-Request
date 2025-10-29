using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Assigments.project_3
{
    public class RentalSystemClass
    {

        List<CarClass> cars;
        List<CustomerClass> customers;
        List<RentalRecordClass> rentalRecords;

        public RentalSystemClass()
        {
            this.cars = new List<CarClass>();
            this.customers = new List<CustomerClass>();
            this.rentalRecords = new List<RentalRecordClass>();
        }




        //indexer, car abailable
        public List<CarClass> this[CarStatus status] { 
            get { 
                List<CarClass> res = new List<CarClass>();
                foreach (CarClass c in this.cars) {
                    if (c.CarStatus == status) {
                        res.Add(c);
                    }
                }   return res;
            }            
        }




        //add car
        public void AddCar(string plate, string model, decimal rate) {
            CarClass car = new CarClass(plate, model, rate);
            cars.Add(car);
        }

        //add customer 
        public void AddCustomer(string name, string phone) {
            CustomerClass customerADD = new CustomerClass(name, phone);
            customers.Add(customerADD); 
        }



        //rent car
        public void rentCar(string customerIN, string platemIN, int dueIN) {
            CustomerClass customer = null;
            foreach (CustomerClass cust in customers)
            {
                if (cust.customerName.ToLower() == customerIN.ToLower())
                {
                    customer = cust;
                    break;
                }
            }

            CarClass car = null;
            foreach (CarClass c in cars) {
                if (c.licensePlate.ToLower() == platemIN.ToLower())
                {
                    car = c;
                    break;
                }
            }
            if (customer == null || car == null || car.CarStatus != CarStatus.available) 
            {return;}

            RentalRecordClass rental = new RentalRecordClass(dueIN, customer, car);
            rentalRecords.Add(rental);  
            car.CarStatus = CarStatus.rented;
        }



        //return car
        public void returnCar(string plate) {
            foreach (CarClass car in cars) {
                if (car.licensePlate.ToLower() == plate.ToLower())
                {
                    car.CarStatus = CarStatus.available;
                    break;
                }
            }
        }




        // calculate total revenue 
        public decimal calcluateTotalRev() { 
            decimal totalRev = 0;
            foreach (RentalRecordClass record in rentalRecords) {
                totalRev += record.totalCost;
            }
            return totalRev;
        }




        //show available cars
        public void showAvailableCars() {
            List<CarClass> AVcars = this[CarStatus.available];
            Console.WriteLine("____ available cars ___");
            if (AVcars.Count == 0 )
            {
                Console.WriteLine("No available cars");
                return;
            }

            foreach (CarClass car in AVcars) {
                Console.WriteLine($"Licences [{car.licensePlate}] | Models [{car.model}] | Daily rate [{car.dailyRate}.OMR]");
                Console.WriteLine("........");
            }
        } 



    }
}
