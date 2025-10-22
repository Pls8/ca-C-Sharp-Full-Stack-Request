using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12_10_2025.Models
{
    public abstract class AnimalClass
    {
        //if no user input requst , no need for contructer
        //protected AnimalClass(string nameAnimal, string typeAnimal, string genderAnimal)
        //{
        //    this.nameAnimal = nameAnimal;
        //    this.typeAnimal = typeAnimal;
        //    this.genderAnimal = genderAnimal;
        //}


        // prop
        public string nameAnimal { get; set; }
        public string typeAnimal { get; set; }
        public string genderAnimal { get; set; }

        public string animalInfo() {
            return $"This is call for main class";
        }
    }
}
