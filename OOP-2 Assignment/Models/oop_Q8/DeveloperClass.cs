using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12_10_2025.Models.oop_Q8
{
    public class DeveloperClass : EmloyeeClass
    {
        public DeveloperClass(string emplName, decimal emplSalary, string codeLang) : base(emplName, emplSalary)
        {                                                                      //   ^---   constructor chaining
            this.codeLang = codeLang;
        }

        public string codeLang { get; set; }    //no need for this, it only indication
                                                // but if you add propties, it must be in constructer drived from EmloyeeClass 
          // this is diffrent way of implent this is needed >-------------v--------------------------v  without need to add body
        //public DeveloperClass(string emplName, decimal emplSalary, ) : this(emplName, emplSalary, "C#")
        //{
        //}


        //override cal
        public override decimal emplCalaulateBouns()
        {
            return emplSalary * .15m;
        }


        //override display info
        public override void emplDisplayInfo()
        {
            Console.WriteLine($"Department {codeLang} | Employ: {emplName} salary: {emplSalary} | bouns: {emplCalaulateBouns()} [+15%]");
        }

    }
}
