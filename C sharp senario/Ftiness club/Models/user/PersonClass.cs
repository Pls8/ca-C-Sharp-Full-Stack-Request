using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FtinessClass.Models.user
{
    public abstract class PersonClass
    {
        // PersonClass inhertiance for member & trainer
        public PersonClass(int id, string fullName, int age) // Constructor
        {
            idPerson = id;
            this.fullName = fullName;
            agePerson = age;
        }


        public int idPerson { get; set; }
        public string fullName { get; set; }
        public int agePerson { get; set; }


        public virtual void displayInfoPerson() {   // Virtual method: polymorphism
            Console.WriteLine($"id: {idPerson} | name: {fullName} | age: {agePerson}");
        }



    }
}
