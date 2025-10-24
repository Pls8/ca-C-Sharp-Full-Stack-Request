using FtinessClass.Models;
using FtinessClass.Models.Enums;
using FtinessClass.Models.Fit;
using System;
using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FtinessClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region class diagram & note
            //________________________________class diagram_______________________________________
            //23-10-2025 something about   \/   |]                                                |
            //                             /    |]                                                |
            //                                                                                    |
            //                          ┌─────────────────┐                                       |
            //                          │   Person        │  (Abstract Base Class)                |
            //                          ├─────────────────┤                                       |
            //                          │ +Id: int        │                                       |
            //                          │ +FullName:string│                                       |
            //                          │ +Age: int       │                                       |
            //                          ├─────────────────┤                                       |
            //                          │ +DisplayInfo()  │  ← virtual method                     |
            //                          └─────────────────┘                                       |
            //                                 △                                                  |
            //                ┌────────────────┼─────────────────┐                                |
            //                │                                  │                                |
            //        ┌───────────────┐                  ┌───────────────┐                        |
            //        │    Member     │                  │   Trainer     │  (Derived Classes)     |
            //        ├───────────────┤                  ├───────────────┤                        |
            //        │ -MembershipType│                 │ -Specialization│                       |
            //        │ -registeredClasses│              │ -assignedClasses│                      |
            //        ├───────────────┤                  ├───────────────┤                        |
            //        │ +CalculateCost()│                │ +AssignToClass()│                      |
            //        │ +RegisterToClass()│              └───────────────┘                        |
            //        └───────────────┘                          △                                |
            //                △                                  │                                |
            //                │                                  │                                |
            //                │                                  │                                |
            //        ┌───────────────┐                  ┌───────────────┐                        |
            //        │ MembershipType│                  │ FitnessClass  │                        |
            //        ├───────────────┤                  ├───────────────┤                        |
            //        │ Monthly       │                  │ +ClassName    │                        |
            //        │ Quarterly     │                  │ +Schedule     │                        |
            //        │ Yearly        │                  │ +Trainer      │  ← COMPOSITION         |
            //        └───────────────┘                  │ -members[]    │  ← COMPOSITION         |
            //                                           ├───────────────┤                        |
            //                                           │ +AddMember()  │                        |
            //                                           │ +ShowDetails()│                        |
            //                                           └───────────────┘                        |
            //                                                   △                                |
            //                                                   │                                |
            //                                                   │                                |
            //                                           ┌───────────────┐                        |
            //                                           │ FitnessCenter │  (Controller)          |
            //                                           ├───────────────┤                        |
            //                                           │ -members[]    │  ← AGGREGATION         |
            //                                           │ -trainers[]   │  ← AGGREGATION         |
            //                                           │ -classes[]    │  ← AGGREGATION         |
            //                                           ├───────────────┤                        |
            //                                           │ +AddMember()  │                        |
            //                                           │ +CreateClass()│                        |
            //                                           │ +AssignTrainer()│                      |
            //                                           └───────────────┘                        |
            //------------------------------------------------------------------------------------/
            // INHERITANCE: Person ◄── Member, Trainer
            //     (Is - a relationship)
            // 
            // COMPOSITION: FitnessClass ──► Trainer(1 trainer per class)
            //                 FitnessClass ──► Member* (many members per class)
            //                 (Strong ownership - parts cannot exist without whole)
            // 
            // AGGREGATION:    FitnessCenter ──► Member* (manages members)
            //                 FitnessCenter ──► Trainer* (manages trainers)
            //                 FitnessCenter ──► FitnessClass* (manages classes)
            //                 (Weak ownership - parts can exist independently)    
            #endregion

            Console.WriteLine("___________Fitness Club system____________");
            FitnessCenterClass club = new FitnessCenterClass();

            // test input ___________________________________________________________
            club.addMember("m1", 30, Models.Enums.MemberShipType.monthly);          //
            club.addMember("m2", 31, Models.Enums.MemberShipType.quarterly);        //
            club.addMember("m3", 32, Models.Enums.MemberShipType.year);             //
                                                                                    //
            club.addTrainer("t1", 35, "cardio");                                    //
            club.addTrainer("t2", 37, "cardio");                                    //
                                                                                    //
            club.createClasses("cardio", "sat/mon 8:00AM");                         //
            club.createClasses("cardio", "wed/fri 10:00PM");                        //
            //----------------------------------------------------------------------//



            int switchNum = 0;
            do {
                Console.WriteLine("\nenter choise");
                Console.WriteLine("1.add member | 2.add trainer | 3.create class | 4.assign trainer to class\n" +
                    "5.register member to class | 6.view member | 7.view trainer | 8.view class | 9.exitLAG ");
                switchNum = int.Parse(Console.ReadLine());


                switch (switchNum)
                { 
                    case 1:
                        Console.WriteLine("1.add memeber");
                        Console.WriteLine("name");                                                                
                        string inName = Console.ReadLine();                                                       
                        Console.WriteLine("age");                                                                 
                        int age = int.Parse(Console.ReadLine());

                        Console.WriteLine("enter 1 , 2 , 3 for memebership type: ");
                        Console.WriteLine("Membership: 1.monthly | 2.quarterly | 3.yearly");                      
                        Console.WriteLine("cost OMR:..   2       | 7         | 14 ");                             
                        int choiceMembership = int.Parse(Console.ReadLine());

                        //ternary operators, there is way by using swicth, but this is easy, i gusse?                        
                        MemberShipType shipType =                                                                 
                            choiceMembership == 1 ? MemberShipType.monthly :                                      
                            choiceMembership == 2 ? MemberShipType.quarterly :                                    
                            choiceMembership == 3 ? MemberShipType.year :                                         
                            MemberShipType.monthly; // defualt value                                              
                        club.addMember(inName, age, shipType);                                                    
                        break;
                    //_______________________________________END


                    case 2:
                        Console.WriteLine("2.add trainer");
                        Console.WriteLine("name: ");
                        string inNameT = Console.ReadLine();
                        Console.WriteLine("age: ");
                        int ageT = int.Parse(Console.ReadLine());
                        Console.WriteLine("specialization: ");
                        string spcializ = Console.ReadLine();
                        club.addTrainer(inNameT, ageT, spcializ);
                        break;
                    //_______________________________________END


                    case 3:
                        Console.WriteLine("3.create class ");
                        Console.WriteLine("class name: ");
                        string className = Console.ReadLine();
                        Console.WriteLine("scedule: ");
                        string secedule = Console.ReadLine();

                        club.createClasses(className, secedule);
                        break;
                    //_______________________________________END


                    case 4:
                        Console.WriteLine("4.assign trainer to class ");
                        club.showAllTrainer();
                        Console.WriteLine("trainer id: ");
                        int trainerID = int.Parse(Console.ReadLine());

                        club.showAllClasses();
                        Console.WriteLine("class name: ");
                        string inputClassName = Console.ReadLine();

                        club.assignTrainerToClass(trainerID, inputClassName);
                        break;
                    //_______________________________________END


                    case 5:
                        Console.WriteLine("5.register memeber to class ");
                        club.showAllMember();
                        Console.WriteLine("memeber ID: ");
                        int memberID = int.Parse(Console.ReadLine());

                        club.showAllClasses();
                        Console.WriteLine("enter class name: ");
                        string inClassName = Console.ReadLine();
                        club.registerMemberToClass(memberID, inClassName);
                        break;
                        //_______________________________________END
                        

                    case 6:
                        Console.WriteLine("6.view memeber ");
                        club.showAllMember();
                        break;
                    //_______________________________________


                    case 7:
                        Console.WriteLine("7.view trianer ");
                        club.showAllTrainer();
                        break;
                    //_______________________________________


                    case 8:
                        Console.WriteLine("8.view memeber ");
                        club.showAllClasses();
                        break;
                    //_______________________________________


                    default:
                        Console.WriteLine("invalid input");
                        break;
                }

            } while (switchNum != 9);
        }
    }
}
