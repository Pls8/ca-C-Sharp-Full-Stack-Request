using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  OOP Assignment 5: Animal Sound Simulation

namespace ConsoleApp12_10_2025.Models
{
    public class DogClass2 : AnimalClass2
    {           // ^ ctrl + .  that > Generate contructer from DogClass2(anmlName)

        public DogClass2(string anmlName) : base(anmlName)
        {
        }


        //public DogClass2(string name) : base(name) { }

        //public string Name { get; set; }

        public override void MakeSound()
        {
            Console.WriteLine($"{anmlName} : Woof!");
        }


    }
}
