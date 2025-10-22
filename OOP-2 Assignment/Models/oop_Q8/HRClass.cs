using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12_10_2025.Models.oop_Q8
{
    public class HRClass
    {
        EmloyeeClass[] emploS;
        int emplCount;

        public HRClass( int sizeEmp = 4)
        {
            emploS = new EmloyeeClass[sizeEmp];
            this.emplCount = 0;
        }


        public void addEmplHR(EmloyeeClass empl) {
            if (emplCount >= emploS.Length) {
                Console.WriteLine("HR system full");
                return;
            }

            emploS[emplCount] = empl;
            emplCount++;
            Console.WriteLine($"Added {empl.emplName}");
        }


        public void displayAllEmpl()
        {
            for (int i = 0; i < emplCount; i++)
            {
                emploS[i].emplDisplayInfo();    //polymorphism, reurnt diffrent bouns base on employee Level
                                                // manger 20%, dev 15%
            }
        }





    }
}
