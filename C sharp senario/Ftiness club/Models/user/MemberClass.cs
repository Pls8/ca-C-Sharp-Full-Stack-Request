using FtinessClass.Models.Enums;
using FtinessClass.Models.Fit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FtinessClass.Models.user
{
    public class MemberClass : PersonClass // inheritance form person
    {  
        public MemberShipType MemberShipType { get; set; }
        List<FitnessClass> registerClass;

        public MemberClass(int id, string fullName, int age, MemberShipType memberShipType) 
            : base(id, fullName, age) // constructer chaining
        {
            MemberShipType = memberShipType;
            registerClass = new List<FitnessClass>();   // Encapsulation?
        }

        public void registerToClass(FitnessClass fitnessClass) {  // AGGREGATION + BIDIRECTIONAL RELATIONSHIP
            if (!registerClass.Contains(fitnessClass)) {
                registerClass.Add(fitnessClass);
                fitnessClass.addMember(this);
                Console.WriteLine($"{fullName} register {fitnessClass.className}");
            }
            else { Console.WriteLine($"{fullName} aleardy register {fitnessClass.className}"); }

            //Member → FitnessClass
            //FitnessClass → Member
        }

        public void showRegisterClass()
        {
            Console.WriteLine($"........{fullName} register class");
            if (registerClass.Count == 0)
            {
                Console.WriteLine("no classes register class");
                return;
            }
            foreach (FitnessClass fitnessClass in registerClass)
            {
                Console.WriteLine($"{fitnessClass.className} | {fitnessClass.schedulE}");
            }
        }

        public decimal calMemberShipCost() {
            switch (MemberShipType)
            {
                case MemberShipType.monthly:
                    return 2m;
                case MemberShipType.quarterly:
                    return 7m;
                case MemberShipType.year:
                    return 14m;
                default:
                    return 0m;
            }
        }

        public override void displayInfoPerson() // method override, polymorphsim
        {
            base.displayInfoPerson();
            Console.WriteLine($"mebership type [ {MemberShipType} ]");
            Console.WriteLine($"membership cost [ {calMemberShipCost()}.OMR ]");
        }

       

    }
}
