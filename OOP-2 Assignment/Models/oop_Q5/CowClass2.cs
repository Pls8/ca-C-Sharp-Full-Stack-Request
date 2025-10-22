using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  OOP Assignment 5: Animal Sound Simulation

namespace ConsoleApp12_10_2025.Models
{
    public class CowClass2 : AnimalClass2
    {           // ^ ctrl + .  that > Generate contructer from CowClass2(anmlName)
        public CowClass2(string anmlName) : base(anmlName)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{anmlName} : Moo!");
        }

    }
}
