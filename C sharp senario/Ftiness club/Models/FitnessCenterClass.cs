using FtinessClass.Models.Enums;
using FtinessClass.Models.Fit;
using FtinessClass.Models.user;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FtinessClass.Models
{
    public class FitnessCenterClass
    {
        //Aggregation 3 List<>: object has references to other objects
        List<MemberClass> members;
        List<TrainerClass> trainers;
        List<FitnessClass> claasses;
        int memberID, trainerID;

        public FitnessCenterClass()
        {
            this.members = new List<MemberClass>();
            this.trainers = new List<TrainerClass>();
            this.claasses = new List<FitnessClass>();
            memberID = 1;
            trainerID = 1;
        }


        public void addMember(string fullName, int age, MemberShipType memberShipType) {
            MemberClass member = new MemberClass(memberID++, fullName, age, memberShipType);
            members.Add(member);
            Console.WriteLine($"member add: {fullName} [id {member.idPerson}]");
        }


        public void showAllMember() {
            Console.WriteLine("............ All memeber .............");
            if (members.Count == 0)
            {
                Console.WriteLine("no member register");
                return;
            }

            foreach (MemberClass member in members)
            {
                member.displayInfoPerson();
                Console.WriteLine("------------");
            }
        }


        public void addTrainer(string fullName, int age, string spc) { 
            TrainerClass trainer = new TrainerClass(trainerID++, fullName, age, spc);
            trainers.Add(trainer);
            Console.WriteLine($"trainer add {fullName}, id {trainer.idPerson}");
        }


        public void showAllTrainer() {
            Console.WriteLine("......... all trainer ..........");
            if (trainers.Count == 0)
            {
                Console.WriteLine("no trainer register");
                return;
            }

            foreach (TrainerClass trainer in trainers)
            {
                trainer.displayInfoPerson();
                Console.WriteLine("--------------");
            }
        }



        public void createClasses(string className, string schdl) { 
            FitnessClass fitnessClass = new FitnessClass(className, schdl);
            claasses.Add(fitnessClass);
            Console.WriteLine($"class created {className} | {schdl}");
        }


        //this is not best imp, the code repted 4 time
        public void assignTrainerToClass(int trainerID, string className) {
            TrainerClass trainer = null;
            FitnessClass fitnessClass = null;


            foreach (TrainerClass trnr in trainers)
            {
                if (trnr.idPerson == trainerID)
                {
                    trainer = trnr;
                    break;
                }
            }

            foreach (FitnessClass cl in claasses)
            {
                if (cl.className == className)
                {
                    fitnessClass = cl;
                    break;
                }
            }


            if (trainer == null)
            {
                Console.WriteLine("trainer not found");
                return;
            }
            if (fitnessClass == null)
            {
                Console.WriteLine("class not found");
                return ;
            }

            trainer.assignToClass(fitnessClass);
        }


        //this is not best imp, the code repted 4 time
        public void registerMemberToClass(int memberID, string className) {
            MemberClass member = null;
            FitnessClass fitnessClass = null;

            foreach (MemberClass m in members)
            {
                if (m.idPerson == memberID)
                {
                    member = m;
                    break;
                }
            }
            foreach (FitnessClass f in claasses)
            {
                if (f.className == className)
                {
                    fitnessClass = f;
                    break;
                }
            }

            if (member == null)
            {
                Console.WriteLine("trainer not found");
                return;
            }
            if (fitnessClass == null)
            {
                Console.WriteLine("class not found");
                return;
            }

            member.registerToClass(fitnessClass); // delegation ?
                                                  // One object hands off responsibility for a task to another object            
        }
                                         //                 Main Program
                                         //                      |
                                         //                      v    delegates
                                         //       Member.RegisterToClass(fitnessClass)
                                         //                      |
                                         //                      v handles
                                         //              +-------------------+
                                         //              | Adds fitnessClass |
                                         //              | to member's list  |
                                         //              | Adds member       |
                                         //              | to class's list   |
                                         //              +-------------------+





        public void showAllClasses() {
            Console.WriteLine(  ".............All fitness class..........");
            if (claasses.Count == 0)
            {
                Console.WriteLine("no classes created");
                return;
            }
            foreach (FitnessClass fitnessclass in claasses) {
                fitnessclass.showClassDetails();
            }
        }



    }
}
