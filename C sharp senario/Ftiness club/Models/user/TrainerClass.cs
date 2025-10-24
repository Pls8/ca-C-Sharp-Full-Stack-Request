using FtinessClass.Models.Fit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FtinessClass.Models.user
{
    public class TrainerClass : PersonClass // inheritance
    {
        public string spcilaziztioN { get; set; }
        List<FitnessClass> assginedClass;

        public TrainerClass(int id, string fullName, int age, string spci) 
            : base(id, fullName, age) // constructer chaning
        {
            spcilaziztioN = spci;
            assginedClass = new List<FitnessClass>();
        }


        // trainer keep list of all fitnessClass OBJECT, Trainer  <>  FitnessClass
        //   +----------------------+     +----------------------+
        //   |      Trainer         |     |    FitnessClass      |
        //   |----------------------|     |----------------------|
        //   | Name: N1             |     | ClassName: cd        |
        //   | assignedClasses: [•] |     | Trainer: (N1) <---+  |
        //   +----------------------+     +-------------------|--+
        //              ^                                     |
        //              |-------------------------------------+
        //
        // class can only have one trainer (1 trainer >  classes)
        // 
        // [Trainer: T1]
        //     |
        //     | teaches
        //     v
        // [FitnessClass: class] ---> has members ---> [Member: m1, m2]
        //     ^                                         |
        //     |------------------- joined --------------|


        public void assignToClass(FitnessClass fitnessClass) {
            if (!assginedClass.Contains(fitnessClass))
            {
                assginedClass.Add(fitnessClass);
                fitnessClass.traineR = this;    // BIDIRECTIONAL RELATIONSHIP : Two objects know about each other
                Console.WriteLine($"{fullName} assign to - {fitnessClass.className}");
            }
            else
            {
                Console.WriteLine($"{fullName} already assign to - {fitnessClass.className}");
            }
        }




        public void showASsignClass() {
            Console.WriteLine($"assign class {fullName}");
            if (assginedClass.Count == 0)
            {
                Console.WriteLine("No class assign");
                return;
            }
            foreach (FitnessClass fitnessClass in assginedClass)
            {
                Console.WriteLine($"{fitnessClass.className} - {fitnessClass.schedulE}");
            }
        }

        public override void displayInfoPerson(){   // method override, poly
            base.displayInfoPerson();
            Console.WriteLine($"specializtion [ {spcilaziztioN} ]");
        }




    }
}
