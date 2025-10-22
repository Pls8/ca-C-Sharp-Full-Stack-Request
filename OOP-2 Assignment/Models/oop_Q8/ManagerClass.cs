using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12_10_2025.Models.oop_Q8
{
    public class ManagerClass : EmloyeeClass // ctrl + .
    {

        // property for manager, no need!
        public string magDepartment { get; set; }

        // constructer with changing
        public ManagerClass(string emplName, decimal emplSalary, string magDepartment) : base(emplName, emplSalary)
        {                                                                         //   ^---   constructor chaining
            this.magDepartment = magDepartment;
        }

        // v--  this if method without useing body, this keyword
        //public ManagerClass(string emplName, decimal emplSalary) : this(emplName, emplSalary, "it")
        //{
        //}


        //override cal, with diffrent imp insted of 10% it will be 20%
        public override decimal emplCalaulateBouns()
        {
            return emplSalary * .20m;
        }


        //override display
        public override void emplDisplayInfo()
        {
            Console.WriteLine($"Department {magDepartment} | Employ: {emplName} salary: {emplSalary} | bouns: {emplCalaulateBouns()} [+20%]");
        }






    }
}
