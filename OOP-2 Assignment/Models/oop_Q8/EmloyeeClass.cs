using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12_10_2025.Models.oop_Q8
{
    public class EmloyeeClass
    {
        public EmloyeeClass(string emplName, decimal emplSalary)
        {
            if (string.IsNullOrWhiteSpace(emplName))
            {
                throw new ArgumentException("Name cannot be empty");
            }

            if (emplSalary < 0)
            {
                throw new ArgumentException("Salary cannot be - ");
            }


            this.emplName = emplName;
            this.emplSalary = emplSalary;
        }

        public string emplName { get; set; }
        public decimal emplSalary { get; set; }



        // virtual method 

        public virtual decimal emplCalaulateBouns() { 
            return emplSalary * .10m; //type suffix m  for error as 0.10 is double? 0.10f = float | 0.10m = decmail 
        }

        public virtual void emplDisplayInfo()
        {
            Console.WriteLine($"Employ: {emplName} | salary: {emplSalary} | bouns: {emplCalaulateBouns()} [10% defualt]");
        }



    }
}
