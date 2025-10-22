using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  OOP Assignment 5: Animal Sound Simulation

namespace ConsoleApp12_10_2025.Models
{
    public class CatClass2 : AnimalClass2
    {           // ^ ctrl + .  that > Generate contructer from CatClass2(anmlName)
        public CatClass2(string anmlName) : base(anmlName)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{anmlName} : Meow!");
        }


        public void thisIsCatClass2()
        {
            Console.WriteLine("this Is Cat Class 2");
        }

    }
}
