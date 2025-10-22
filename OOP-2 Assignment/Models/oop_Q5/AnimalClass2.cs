using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  OOP Assignment 5: Animal Sound Simulation

namespace ConsoleApp12_10_2025.Models
{
    public abstract class AnimalClass2
    {
        protected AnimalClass2(string anmlName)
        {
            this.anmlName = anmlName;
        }

        public string anmlName { get; set; }

        public abstract void MakeSound();


        //for testing foreach
        public void commonBehv() {
            Console.WriteLine($"{anmlName} share this");
        }
    }
}
