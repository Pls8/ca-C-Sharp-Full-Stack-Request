using ConsoleApp12_10_2025.Models;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace ConsoleApp12_10_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            #region 𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 5: 𝙋𝙖𝙧𝙠𝙞𝙣𝙜 𝙇𝙤𝙩 𝙎𝙮𝙨𝙩𝙚𝙢
            //////////////////////////////////////////////////////////////////
            ////            𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 5: 𝙋𝙖𝙧𝙠𝙞𝙣𝙜 𝙇𝙤𝙩 𝙎𝙮𝙨𝙩𝙚𝙢
            //_______________________________________________________________ S T A R T
            Console.WriteLine("Parking Lot");
            string[] slot = new string[10];
            int choicePkSwitch;
            do {
               Console.WriteLine("Option");
               Console.WriteLine("1.Park a car | 2.Remove Car | 3.View Slot | 4.Find a Car | 5.Exit");
               choicePkSwitch = int.Parse(Console.ReadLine());

               switch (choicePkSwitch)
               {
                   case 1://park(add)
                       Console.WriteLine("Enter car license number of car");

                       string licenseInput = Console.ReadLine().ToUpper();
                       int tempSlot = -1; // -1, zero 0 will point to index !

                       //check car in slot?
                       for (int i = 0; i < slot.Length; i++)
                       {
                           if (slot[i] == licenseInput){
                               Console.WriteLine("Car already parked");
                               return;
                           }
                       }

                       //assign car slot
                       for (int i = 0; i < slot.Length; i++)
                       {
                           // slots[i] == null || slots[i] == "" < diffrent way of writing
                           if (string.IsNullOrEmpty(slot[i]))
                           {
                               tempSlot = i;
                               break;
                           }
                       }
                       if (tempSlot != -1)
                       {
                           slot[tempSlot] = licenseInput;
                           Console.WriteLine($"car parked {tempSlot} + 1");
                       }
                       else { Console.WriteLine("Parking is full"); }
                       break;


                   case 2://remove car
                       Console.WriteLine("Enter car license to remove: ");

                       tempSlot = -1;
                       licenseInput = Console.ReadLine().ToUpper();

                       for (int i = 0; i < slot.Length; i++)
                       {
                           if (slot[i] == licenseInput)
                           {
                               tempSlot = i;
                               break;
                           }
                       }
                       if (tempSlot != 1)
                       {
                           slot[tempSlot] = ""; // empty?
                           Console.WriteLine($"Car {licenseInput} remove from {tempSlot} + 1"); //Point to index
                       }
                       else {
                           Console.WriteLine("Car not found!");
                       }
                        break;


                   case 3://view
                       Console.WriteLine("Slot | Linence");
                       for (int i = 0; i < slot.Length; i++) {
                           Console.WriteLine($"{i} | {slot[i]}");
                       }                       
                   break;


                   case 4://search
                       Console.WriteLine("Enter car license to serach");

                       tempSlot = -1;
                       licenseInput = Console.ReadLine().ToUpper();
                       for (int i = 0; i < slot.Length; i++)
                       {
                           if (slot[i] == licenseInput)
                           {
                               tempSlot = i;
                               break ;
                           }
                       }
                       if (tempSlot != -1 )
                       {
                           Console.WriteLine($"Car {licenseInput} found in slot {tempSlot} + 1");
                       }
                       else
                       {
                           Console.WriteLine("Car not found!");
                       }
                       break;

                   default:
                       Console.WriteLine("Invalid choice! Please select 1-5.");
                       break;
               }
            } while (choicePkSwitch != 5);

            //------------------------------------------------------------------------------------------------- E N D
            //                       𝘼𝙨𝙨𝙞𝙜𝙣𝙢𝙚𝙣𝙩 5: 𝙋𝙖𝙧𝙠𝙞𝙣𝙜 𝙇𝙤𝙩 𝙎𝙮𝙨𝙩𝙚𝙢 
            ///////////////////////////////////////////////////////////////////////////////////////////////////
            #endregion




        }
    }

}
